using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.DeleteReq)]
    public readonly struct CharacterDeleteRequest
    {
        public readonly int CharacterId;

        internal CharacterDeleteRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
