using SoulWorkerResearch.SoulCore.Defines;
using System.Runtime.CompilerServices;

namespace SoulWorkerResearch.SoulCore.IO.Net.Extensions;

public static class BinaryReaderExtension
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PacketProtocol ReadPacketProtocol(this BinaryReader br) => (PacketProtocol)br.ReadByte();
}
