using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

public readonly struct PacketHeader
{
    public static PacketHeader Empty => new();

    public PacketMagick Magic { get; init; }
    public ushort Size { get; init; }
    public PacketProtocol Protocol { get; init; }

    public PacketHeader(BinaryReader reader)
    {
        Magic = new PacketMagick(reader);
        Size = reader.ReadUInt16();
        Protocol = reader.ReadPacketProtocol();
    }

    public PacketHeader()
    {
        Magic = new();
        Protocol = PacketProtocol.Game;
    }
}
