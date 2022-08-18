using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

public readonly struct PacketHeader
{
    #region Contants

    public static PacketHeader Empty { get; } = new PacketHeader();

    #endregion Contants

    #region IPacketHeader

    public PacketMagick Magick { get; init; }
    public ushort Size { get; init; }
    public PacketProtocol Protocol { get; init; }
    public byte Key { get; init; }

    #endregion IPacketHeader

    #region Constructors

    public PacketHeader(BinaryReader reader)
    {
        Magick = new PacketMagick(reader);
        Size = reader.ReadUInt16();
        Protocol = reader.ReadPacketProtocol();
        Key = reader.ReadByte();
    }

    #endregion Constructors
}
