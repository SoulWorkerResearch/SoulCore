using System.IO;
using SoulCore.IO.Network.Responses.Shared;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.EnterGameServer)]
    public readonly struct CharacterEnterGameServerRequest
    {
        public int Account { get; }
        public int Character { get; }
        public MapIdPacketSharedStructure MapId { get; }
        public byte FirstConnect { get; }
        public ulong SessionKey { get; }

        internal CharacterEnterGameServerRequest(BinaryReader br)
        {
            Account = br.ReadInt32();
            Character = br.ReadInt32();
            MapId = new(br);
            FirstConnect = br.ReadByte();
            SessionKey = br.ReadUInt64();
        }
    }
}
