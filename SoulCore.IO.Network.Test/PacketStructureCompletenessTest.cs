using ow.Framework.Tests;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Requests;
using SoulCore.IO.Network.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SoulCore.IO.Network.Test
{
    public sealed class PacketStructureCompletenessTest : IClassFixture<Startup>
    {
        private readonly Dictionary<ushort, Type> _requests = new();

        [Fact]
        public void StructureTest()
        {
            AddRequest<SRMMoveRequest>(CategoryCommand.Move, MoveCommand.Move);

            using FileStream fs = File.OpenRead(@"data\packet.bin");
            using BinaryReader br = new(fs);

            while (fs.Position != fs.Length)
            {
                var packet = new PacketHeader(br);

                // SoulWorker Magic
                Assert.Equal(Defines.PacketHeaderMagic1, packet.Magic0);
                Assert.Equal(Defines.PacketHeaderMagic2, packet.Magic1);
                Assert.True(packet.usTos == 1 || packet.usTos == 2);

                RequestTest(br.ReadBytes(packet.Size - Defines.PacketHeaderSize));
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
                _ = Activator.CreateInstance(request, new object[] { br });
                Assert.Equal(ms.Length, ms.Position);
            }
        }

        private void AddRequest<T>(CategoryCommand category, object command)
        {
            // category = 0x04
            // command = 0x01
            // index = 0x0401
            ushort index = (ushort)((byte)command + (((byte)category) << 8));
            _requests[index] = typeof(T);
        }
    }
}