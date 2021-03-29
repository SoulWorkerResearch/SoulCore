using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ProfilePhotoChange)]
    public readonly struct CharacterProfilePhotoChangeRequest
    {
        public readonly int CharacterId;

        internal CharacterProfilePhotoChangeRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
