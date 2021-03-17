using ow.Framework.Tests;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Utils;
using SoulCore.Misc.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace SoulCore.IO.Network.Test
{
    public sealed class PacketStructureCompletenessTest : IClassFixture<Startup>
    {
        [Fact]
        public ValueTask RequestStructureTest() => PacketsTest<RequestAttribute>(@"data\requests.bin");

        [Fact]
        public ValueTask ResponseStructureTest() => PacketsTest<ResponseAttribute>(@"data\responses.bin");

        private async ValueTask PacketsTest<TAttribute>(string path)
            where TAttribute : BasePacketAttribute
        {
            await using FileStream fs = File.OpenRead(path);
            using BinaryReader br = new(fs);

            IReadOnlyDictionary<ushort, Type> packets = RegisterPackets<TAttribute>();

            while (fs.Position != fs.Length)
            {
                PacketHeader packet = new(br);

                // SoulWorker Magic
                Assert.Equal(CommonDefines.PacketHeaderMagic1, packet.Magic0);
                Assert.Equal(CommonDefines.PacketHeaderMagic2, packet.Magic1);

                Assert.True(packet.UsTos == 1 || packet.UsTos == 2);

                await PacketTest(br.ReadBytes(packet.Size - CommonDefines.PacketHeaderSize), packets).ConfigureAwait(false);
            }
        }

        private static async ValueTask PacketTest(byte[] raw, IReadOnlyDictionary<ushort, Type> packets)
        {
            PacketUtils.Exchange(ref raw);

            await using MemoryStream ms = new(raw, false);
            using BinaryReader br = new(ms);

            ushort command = br.ReadUInt16();
            if (packets.TryGetValue(command, out Type? request))
            {
                const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
                _ = Activator.CreateInstance(request, flags, null, new object[] { br }, null, null);

                Assert.Equal(ms.Length, ms.Position);
            }
        }

        private static bool CompareRequest<TAttribute>(Type t, CategoryCommand categoryValue, byte commandValue)
            where TAttribute : BasePacketAttribute
        {
            BasePacketAttribute attribute = t.GetCustomAttribute<TAttribute>() ?? throw new XunitException();
            return attribute.Category == categoryValue && attribute.Command == commandValue;
        }

        private static IReadOnlyDictionary<ushort, Type> RegisterPackets<TAttribute>()
            where TAttribute : BasePacketAttribute
        {
            Dictionary<CategoryCommand, Type> categoryTypes = GetTypesByAttribute<CategoryCommandAttribute>().ToDictionary(k => k.GetCustomAttribute<CategoryCommandAttribute>()!.Category, v => v);

            Type[] requests = GetTypesByAttribute<TAttribute>().ToArray();

            return new Dictionary<ushort, Type>(Enum.GetValues<CategoryCommand>().SelectMany(categoryValue =>
            {
                Dictionary<ushort, Type> packets = new();

                if (categoryTypes.TryGetValue(categoryValue, out Type? categoryType))
                {
                    foreach (object commandValue in Enum.GetValues(categoryType))
                    {
                        if (Array.Find(requests, type => CompareRequest<TAttribute>(type, categoryValue, (byte)commandValue)) is Type request)
                        {
                            packets[CommonHelper.MakeWord((byte)categoryValue, (byte)commandValue)] = request;
                        }
                    }
                }
                else
                {
                    throw new XunitException("Unknown packet category");
                }

                return packets;
            }));
        }

        private static IEnumerable<Type> GetTypesByAttribute<TAttribute>() where TAttribute : Attribute => AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => a.FullName?.Contains("SoulCore") ?? throw new XunitException("SoulCore namespace not found"))
            .SelectMany(a => a.GetTypes())
            .Where(t => t.GetCustomAttribute<TAttribute>() is not null);
    }
}