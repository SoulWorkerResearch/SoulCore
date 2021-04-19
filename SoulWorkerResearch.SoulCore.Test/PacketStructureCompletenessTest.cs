using Microsoft.Extensions.Configuration;
using SoulWorkerResearch.SoulCore.IO.Network;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.Misc.Helpers;
using SoulWorkerResearch.Wireshark.PacketReader;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Sdk;

namespace SoulWorkerResearch.SoulCore.Test
{
    public sealed class PacketStructureCompletenessTest : IClassFixture<Startup>
    {
        [Fact]
        public void RequestStructureTest() => PacketsTest<RequestAttribute>(_requestsPath);

        [Fact]
        public void ResponseStructureTest() => PacketsTest<ResponseAttribute>(_responsesPath);

        public PacketStructureCompletenessTest(Startup startup)
        {
            var configuration = startup.ServiceProvider.GetRequiredService<IConfiguration>();
            
            var path = configuration["Wireshark:JsonDumpPath"];
            Assert.NotNull(path);

            var ip = configuration["Wireshark:ClientIp"];
            Assert.NotNull(path);

            IEnumerable<IEnumerable<IReadOnlyRawPacket>> packets = JsonFile.ReadAsync(path).GetAwaiter().GetResult();

            // Write requests packets temp file
            Write(_requestsPath = Path.GetTempFileName(), packets.Select(raws => raws.Where(raw => raw.SrcIp == ip)));

            // Write responses packetes temp file
            Write(_responsesPath = Path.GetTempFileName(), packets.Select(raws => raws.Where(raw => raw.SrcIp != ip)));
        }

        private readonly string _requestsPath;
        private readonly string _responsesPath;

        private static void Write(string filepath, IEnumerable<IEnumerable<IReadOnlyRawPacket>> splitteds)
        {
            using FileStream requests = File.Open(filepath, FileMode.Create, FileAccess.Write);
            foreach (IEnumerable<IReadOnlyRawPacket> packets in splitteds)
            {
                HashSet<ulong> written = new();
                foreach (IReadOnlyRawPacket packet in packets)
                {
                    HierarchyWrite(packet, packets, written, requests);
                }
            }
        }

        private static void HierarchyWrite(IReadOnlyRawPacket packet, IEnumerable<IReadOnlyRawPacket> packets, HashSet<ulong> written, FileStream fs)
        {
            // If this frame already written...
            if (!written.Add(packet.Frame))
            {// ...skip it
                return;
            }

            // Write packet bytes
            fs.Write(packet.Payload);

            // And do next
            HierarchyWrite(packets.First(s => s.StreamSeqId == packet.StreamNextSeqId), packets, written, fs);
        }

        private static void PacketsTest<TAttribute>(string path) where TAttribute : BasePacketAttribute
        {
            // Register exists packets
            IReadOnlyDictionary<ushort, Type> packets = RegisterPackets<TAttribute>();

            // Open packets dump
            using BinaryReader br = new(File.OpenRead(path), Encoding.ASCII, false);

            // Read until EOF
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                // Read packet header
                PacketHeader packet = new(br);

                // Check SoulWorker first magic
                Assert.Equal(CommonDefines.PacketHeaderMagic1, packet.Magic0);

                // Check SoulWorker second magic
                Assert.Equal(CommonDefines.PacketHeaderMagic2, packet.Magic1);

                // Check SoulWorker ...? value
                Assert.True(Enum.IsDefined(packet.UsTos));

                PacketTest(br.ReadBytes(packet.BodySize - CommonDefines.PacketHeaderSize), packets);
            }
        }

        private static void PacketTest(byte[] raw, IReadOnlyDictionary<ushort, Type> packets)
        {
            var testServer = new TestServer();
            testServer.OnPacketExchange(raw.AsSpan());
            // PacketUtils.Exchange(ref raw);

            using BinaryReader br = new(new MemoryStream(raw, false), Encoding.ASCII, false);

            // Read minor and major packet opcode
            ushort command = br.ReadUInt16();

            // Try get registered packet type...
            if (packets.TryGetValue(command, out Type? request))
            { // ...and if they registered
                // Use public and internal constructors
                const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;

                // Try create packet instance
                object? instance = Activator.CreateInstance(request, flags, null, new object[] { br }, null, null);

                // Check if instance are created
                Assert.Null(instance);

                // Packet instance read all raw packet body
                Assert.Equal(br.BaseStream.Length, br.BaseStream.Position);
            }
        }

        private static bool CompareRequest<TAttribute>(Type t, CategoryCommand categoryValue, byte commandValue) where TAttribute : BasePacketAttribute
        {
            BasePacketAttribute attribute = t.GetCustomAttribute<TAttribute>() ?? throw new XunitException($"GetCustomAttribute<{nameof(TAttribute)}> is null");
            return attribute.Category == categoryValue && attribute.Command == commandValue;
        }

        private static IReadOnlyDictionary<ushort, Type> RegisterPackets<TPacketAttribute>() where TPacketAttribute : BasePacketAttribute
        {
            IReadOnlyDictionary<CategoryCommand, Type> categoryTypes = GetTypesByAttribute<CategoryCommandAttribute>().ToDictionary(k => k.GetCustomAttribute<CategoryCommandAttribute>()!.Category, v => v);

            IReadOnlyList<Type> packetsExists = GetTypesByAttribute<TPacketAttribute>().ToArray();

            return new Dictionary<ushort, Type>(Enum.GetValues<CategoryCommand>().SelectMany(categoryValue =>
            {
                Dictionary<ushort, Type> registeredPackets = new();

                if (categoryTypes.TryGetValue(categoryValue, out Type? categoryType))
                {
                    foreach (object commandValue in Enum.GetValues(categoryType))
                    {
                        if (packetsExists.FirstOrDefault(type => CompareRequest<TPacketAttribute>(type, categoryValue, (byte)commandValue)) is Type type)
                        {
                            // Create full opcode
                            ushort opcode = CommonHelper.MakeWord((byte)categoryValue, (byte)commandValue);

                            // Try register packet type
                            Assert.False(registeredPackets.TryAdd(opcode, type), $"{nameof(TPacketAttribute)}:0x{opcode:X4} can't register packet");
                        }
                    }
                }
                else
                {
                    throw new XunitException("Unknown packet category");
                }

                return registeredPackets;
            }));
        }

        private static IEnumerable<Type> GetTypesByAttribute<TAttribute>() where TAttribute : Attribute => AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(AssemblyCheckName)
            .SelectMany(AssemblyGetTypes)
            .Where(t => t.GetCustomAttribute<TAttribute>() is not null);

        private static bool AssemblyCheckName(Assembly assembly) => assembly.FullName
            ?.Contains("SoulWorkerResearch.SoulCore")
            ?? throw new XunitException("namespace SoulWorkerResearch.SoulCore not found");

        private static IEnumerable<Type> AssemblyGetTypes(Assembly assembly) => assembly.GetTypes();
    }
}