using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ChangeMotionReq)]
    public readonly struct CharacterChangeMotionRequest
    {
        public readonly int CharacterId;
        public readonly short SubMotion;

        internal CharacterChangeMotionRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            SubMotion = br.ReadInt16();
        }
    }
}
