using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.SelectReq)]
    public readonly struct CharacterSelectRequest
    {
        public readonly int CharacterId;
        public readonly int AccountId;
        public readonly bool ClearTutorial;
        public readonly int PreviousMapId;
        public readonly int PreviousRevivePoint;

        internal CharacterSelectRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            AccountId = br.ReadInt32();
            ClearTutorial = br.ReadBoolean();
            PreviousMapId = br.ReadInt32();
            PreviousRevivePoint = br.ReadInt32();
        }
    }
}
