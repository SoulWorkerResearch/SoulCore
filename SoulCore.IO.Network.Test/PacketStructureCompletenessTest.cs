using ow.Framework.Tests;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace SoulCore.IO.Network.Test
{
    public sealed class PacketStructureCompletenessTest : IClassFixture<Startup>
    {
        private readonly IReadOnlyDictionary<ushort, Type> _requests = RegisterRequests();
        private readonly IReadOnlyDictionary<ushort, Type> _responses = RegisterResponses();

        [Fact]
        public void RequestStructureTest()
        {
            using FileStream fs = File.OpenRead(@"data\requests.bin");
            using BinaryReader br = new(fs);

            while (fs.Position != fs.Length)
            {
                PacketHeader packet = new(br);

                // SoulWorker Magic
                Assert.Equal(Defines.PacketHeaderMagic1, packet.Magic0);
                Assert.Equal(Defines.PacketHeaderMagic2, packet.Magic1);

                Assert.True(packet.UsTos == 1 || packet.UsTos == 2);

                RequestTest(br.ReadBytes(packet.Size - Defines.PacketHeaderSize));
            }
        }

        [Fact]
        public void ResponseStructureTest()
        {
            using FileStream fs = File.OpenRead(@"data\responses.bin");
            using BinaryReader br = new(fs);

            while (fs.Position != fs.Length)
            {
                PacketHeader packet = new(br);

                // SoulWorker Magic
                Assert.Equal(Defines.PacketHeaderMagic1, packet.Magic0);
                Assert.Equal(Defines.PacketHeaderMagic2, packet.Magic1);

                Assert.True(packet.UsTos == 1 || packet.UsTos == 2);

                ResponseTest(br.ReadBytes(packet.Size - Defines.PacketHeaderSize));
            }
        }

        private void ResponseTest(byte[] raw)
        {
            PacketUtils.Exchange(ref raw);

            using MemoryStream ms = new(raw, false);
            using BinaryReader br = new(ms);

            ushort command = br.ReadUInt16();
            if (_responses.TryGetValue(command, out Type request))
            {
                const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
                _ = Activator.CreateInstance(request, flags, null, new object[] { br }, null, null);

                Assert.Equal(ms.Length, ms.Position);
            }
        }

        private void RequestTest(byte[] raw)
        {
            PacketUtils.Exchange(ref raw);

            using MemoryStream ms = new(raw, false);
            using BinaryReader br = new(ms);

            ushort command = br.ReadUInt16();
            if (_requests.TryGetValue(command, out Type request))
            {
                const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
                _ = Activator.CreateInstance(request, flags, null, new object[] { br }, null, null);

                Assert.Equal(ms.Length, ms.Position);
            }
        }

        private static IReadOnlyDictionary<ushort, Type> RegisterResponses()
        {
            Dictionary<ushort, Type> response = new();

            Dictionary<CategoryCommand, Type> categoryTypes = GetTypesByAttribute<CategoryCommandAttribute>().ToDictionary(k => k.GetCustomAttribute<CategoryCommandAttribute>()!.Category, v => v);

            Type[] requests = GetTypesByAttribute<ResponseAttribute>().ToArray();

            foreach (CategoryCommand categoryValue in Enum.GetValues<CategoryCommand>())
            {
                if (categoryTypes.TryGetValue(categoryValue, out Type category))
                {
                    foreach (object commandValue in Enum.GetValues(category))
                    {
                        Type request = Array.Find(requests, t =>
                        {
                            RequestAttribute a = t.GetCustomAttribute<RequestAttribute>()!;
                            return a.Category == categoryValue && a.Command == (byte)commandValue;
                        });

                        if (request is not null)
                        {
                            // category = 0x04
                            // command = 0x01
                            // index = 0x0401
                            ushort index = (ushort)((byte)categoryValue + (((byte)commandValue) << 8));
                            response[index] = request;
                        }
                    }
                }
                else
                {
                    throw new XunitException("Category not found");
                }
            }

            return response;
        }

        private static IReadOnlyDictionary<ushort, Type> RegisterRequests()
        {
            Dictionary<ushort, Type> response = new();

            Dictionary<CategoryCommand, Type> categoryTypes = GetTypesByAttribute<CategoryCommandAttribute>().ToDictionary(k => k.GetCustomAttribute<CategoryCommandAttribute>()!.Category, v => v);

            Type[] requests = GetTypesByAttribute<RequestAttribute>().ToArray();

            foreach (CategoryCommand categoryValue in Enum.GetValues<CategoryCommand>())
            {
                if (categoryTypes.TryGetValue(categoryValue, out Type category))
                {
                    foreach (object commandValue in Enum.GetValues(category))
                    {
                        Type request = Array.Find(requests, t =>
                        {
                            RequestAttribute a = t.GetCustomAttribute<RequestAttribute>()!;
                            return a.Category == categoryValue && a.Command == (byte)commandValue;
                        });

                        if (request is not null)
                        {
                            // category = 0x04
                            // command = 0x01
                            // index = 0x0401
                            ushort index = (ushort)((byte)categoryValue + (((byte)commandValue) << 8));
                            response[index] = request;
                        }
                    }
                }
                else
                {
                    throw new XunitException("Category not found");
                }
            }

            return response;
        }

        private static IEnumerable<Type> GetTypesByAttribute<T>() where T : Attribute => AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => a.FullName.Contains("SoulCore"))
            .SelectMany(a => a.GetTypes())
            .Where(t => t.GetCustomAttribute<T>() is not null);
    }
}