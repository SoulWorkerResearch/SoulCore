using ow.Framework.Tests;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Requests;
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
                // SoulWorker Magic
                Assert.Equal(Defines.PacketHeaderMagic1, br.ReadByte());
                Assert.Equal(Defines.PacketHeaderMagic2, br.ReadByte());

                // Packet Length
                int length = br.ReadUInt16() - Defines.PacketHeaderSize;

                long need = fs.Position + length;

                // ???
                fs.Position += sizeof(byte);

                RequestTest(br.ReadBytes(length));
            }
        }

        private void RequestTest(byte[] raw)
        {
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
            ushort index = (ushort)((byte)category + (((byte)command) << 8));
            _requests[index] = typeof(T);
        }
    }
}