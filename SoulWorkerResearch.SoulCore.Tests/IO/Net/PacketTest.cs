using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Packet;

namespace SoulWorkerResearch.SoulCore.Tests.IO.Net;

[TestClass]
public sealed class PacketTest
{
    [TestMethod]
    public void HeaderMagic0Test()
    {
        Assert.AreEqual(GameConfig.PacketHeaderMagic0, _header.Magic.Left, "Bad first magick");
    }

    [TestMethod]
    public void HeaderMagic1Test()
    {
        Assert.AreEqual(GameConfig.PacketHeaderMagic1, _header.Magic.Right, "Bad second magick");
    }

    [TestMethod]
    public void HeaderSizeTest()
    {
        Assert.AreEqual(GameConfig.PacketHeaderSize, _header.Size, "Bad packet size");
    }

    [TestMethod]
    public void HeaderProtocolTest()
    {
        Assert.AreEqual(PacketProtocol.Game, _header.Protocol, "Bad protocol value");
    }

    [TestMethod]
    public void HeaderKeyTest()
    {
        // Assert.AreEqual(_keyValue, _header.Key, "Bad key value");
    }

    static PacketTest()
    {
        using var stream = new MemoryStream();
        using var writer = new BinaryWriter(stream);

        writer.Write(MakePacket());

        stream.Position = 0;

        using var reader = new BinaryReader(stream);
        _header = new PacketHeader(reader);
    }

    private static PacketHeader MakePacket()
    {
        return new()
        {
            Magic = new PacketMagick(null, null),
            Size = GameConfig.PacketHeaderSize,
            Protocol = PacketProtocol.Game,
            // Key = _keyValue
        };
    }

    private static readonly PacketHeader _header;
    // private static readonly byte _keyValue = 7;
}
