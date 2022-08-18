using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Packet;
using System.IO;

namespace SoulWorkerResearch.SoulCore.Tests.IO.Net;

[TestClass]
public sealed class PacketTest
{
    #region Methods

    [TestMethod]
    public void HeaderMagic0Test()
    {
        Assert.AreEqual(Config.PacketHeaderMagic0, _header.Magick.Left, "Bad first magick");
    }

    [TestMethod]
    public void HeaderMagic1Test()
    {
        Assert.AreEqual(Config.PacketHeaderMagic1, _header.Magick.Right, "Bad second magick");
    }

    [TestMethod]
    public void HeaderSizeTest()
    {
        Assert.AreEqual(Config.PacketHeaderSize, _header.Size, "Bad packet size");
    }

    [TestMethod]
    public void HeaderProtocolTest()
    {
        Assert.AreEqual(PacketProtocol.ServerClient, _header.Protocol, "Bad protocol value");
    }

    [TestMethod]
    public void HeaderKeyTest()
    {
        Assert.AreEqual(_keyValue, _header.Key, "Bad key value");
    }

    #endregion Methods

    #region Static Constructors
    
    static PacketTest()
    {
        using var stream = new MemoryStream();
        using var writer = new BinaryWriter(stream);

        writer.Write(MakePacket());

        stream.Position = 0;

        using var reader = new BinaryReader(stream);
        _header = new PacketHeader(reader);
    }


    #endregion Static Constructors

    #region Private Static Methods

    private static PacketHeader MakePacket() => new()
    {
        Magick = new PacketMagick(null, null),
        Size = Config.PacketHeaderSize,
        Protocol = PacketProtocol.ServerClient,
        Key = _keyValue,
    };

    #endregion Private Static Methods

    #region Private Static Fields

    private static readonly PacketHeader _header;
    private static readonly byte _keyValue = 7;

    #endregion Private Static Fields
}
