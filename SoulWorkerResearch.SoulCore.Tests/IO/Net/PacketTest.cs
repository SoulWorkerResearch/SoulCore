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
        using var stream = new MemoryStream();
        using var writer = new BinaryWriter(stream);

        writer.Write(MakePacket());

        stream.Position = 0;

        using var reader = new BinaryReader(stream);
        var header = new PacketHeader(reader);

        Assert.AreEqual(Config.PacketHeaderMagic0, header.Magick.Left, "Bad first magick");
        Assert.AreEqual(Config.PacketHeaderMagic1, header.Magick.Right, "Bad second magick");
        Assert.AreEqual(Config.PacketHeaderSize, header.Size, "Bad packet size");
        Assert.AreEqual(PacketProtocol.ServerClient, header.Protocol, "Bad protocol value");
        Assert.AreEqual(_keyValue, header.Key, "Bad key value");
    }

    private static PacketHeader MakePacket() => new()
    {
        Magick = new PacketMagick(null, null),
        Size = Config.PacketHeaderSize,
        Protocol = PacketProtocol.ServerClient,
        Key = _keyValue,
    };

    private static readonly byte _keyValue = 7;
}
