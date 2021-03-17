using SoulCore.IO.Network.PacketSharedStructure;
using SoulCore.IO.Network.Responses.Shared;

namespace SoulCore.IO.Network.Responses
{
    public abstract record MapInfoShared
    {
        public int AccountId { get; init; }
        public int CharacterId { get; init; }
        public uint ServerId { get; init; }
        public uint JumpId { get; init; }
        public uint PortalId { get; init; }
        public SEndPointSharedResponse EndPoint { get; init; } = SEndPointSharedResponse.Empty;
        public MapIdPacketSharedStructure Map { get; init; }
        public MapIdPacketSharedStructure ParentMap { get; init; }
        public PositionInfoPacketSharedStructure Pos { get; init; } = PositionInfoPacketSharedStructure.Empty;
        public byte Type { get; init; }
    }
}