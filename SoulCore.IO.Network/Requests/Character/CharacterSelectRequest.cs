using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.SelectReq)]
    public readonly struct CharacterSelectRequest
    {
        public readonly int CharacterId;
        public readonly int AccountId;
        public readonly bool ClearTutorial;
        public readonly int PrevMapID;
        public readonly int PrevRevivePoint;

        internal CharacterSelectRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            AccountId = br.ReadInt32();
            ClearTutorial = br.ReadBoolean();
            PrevMapID = br.ReadInt32();
            PrevRevivePoint = br.ReadInt32();
        }
    }
}