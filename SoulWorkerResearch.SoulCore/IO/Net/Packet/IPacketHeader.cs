using SoulWorkerResearch.SoulCore.Defines;

namespace SoulWorkerResearch.SoulCore.IO.Net.Packet;

public interface IPacketHeader
{
    IPacketMagick Magick { get; }
    ushort Size { get; }
    PacketProtocol Protocol { get; }
}
