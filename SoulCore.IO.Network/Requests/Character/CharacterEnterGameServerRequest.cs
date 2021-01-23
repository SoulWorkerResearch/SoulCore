using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Responses.Shared;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct CharacterEnterGameServerRequest
    {
        public int Account { get; }
        public int Character { get; }
        public MapIdPacketSharedStructure MapId { get; }
        public byte FirstConnect { get; }
        public ulong SessionKey { get; }

        public CharacterEnterGameServerRequest(BinaryReader br)
        {
            Account = br.ReadInt32();
            Character = br.ReadInt32();
            MapId = new(br);
            FirstConnect = br.ReadByte();
            SessionKey = br.ReadUInt64();
        }
    }
}