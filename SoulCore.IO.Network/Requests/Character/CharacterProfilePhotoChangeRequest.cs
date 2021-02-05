using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ProfilePhotoChange)]
    public readonly struct CharacterProfilePhotoChangeRequest
    {
        public readonly int CharacterId;

        internal CharacterProfilePhotoChangeRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}