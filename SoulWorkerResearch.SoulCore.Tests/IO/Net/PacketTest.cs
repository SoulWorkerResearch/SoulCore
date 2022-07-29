using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Packet;
using System.IO;

namespace SoulWorkerResearch.SoulCore.Tests.IO.Net;

[TestClass]
public sealed class PacketTest
{
    [TestMethod]
    public void HeaderTest()
    {
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);

        bw.Write(Config.PacketHeaderMagic0);
        bw.Write(Config.PacketHeaderMagic1);
        bw.Write((ushort)Config.PacketHeaderSize);
        bw.Write(PacketProtocol.ServerClient);

        ms.Position = 0;

        using var reader = new BinaryReader(ms);
        IPacketHeader header = new PacketHeader(reader);

        Assert.AreEqual(Config.PacketHeaderMagic0, header.Magick.Left, "Bad first magick");
        Assert.AreEqual(Config.PacketHeaderMagic1, header.Magick.Right, "Bad second magick");
        Assert.AreEqual(Config.PacketHeaderSize, header.Size, "Bad packet size");
        Assert.AreEqual(PacketProtocol.ServerClient, header.Protocol, "Bad protocol value");
    }
}
