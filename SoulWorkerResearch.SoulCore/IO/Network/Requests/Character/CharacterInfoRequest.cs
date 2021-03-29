using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.InfoReq)]
    public readonly struct CharacterInfoRequest
    {
        public readonly int CharacterId;
        public readonly byte _1;

        internal CharacterInfoRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            _1 = br.ReadByte();
        }
    }
}
