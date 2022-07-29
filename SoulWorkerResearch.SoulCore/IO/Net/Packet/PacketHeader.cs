using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

public readonly struct PacketHeader : IPacketHeader
{
    #region Contants

    public static PacketHeader Empty { get; } = new PacketHeader();

    #endregion Contants

    #region IPacketHeader

    public IPacketMagick Magick { get; }

    public ushort Size { get; }

    public PacketProtocol Protocol { get; }

    #endregion IPacketHeader

    #region Constructors

    public PacketHeader(BinaryReader reader)
    {
        Magick = new PacketMagick(reader);
        Size = reader.ReadUInt16();
        Protocol = reader.ReadPacketProtocol();
    }

    #endregion Constructors
}
