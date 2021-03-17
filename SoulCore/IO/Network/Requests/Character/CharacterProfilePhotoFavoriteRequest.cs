using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ProfilePhotoFavorite)]
    public readonly struct CharacterProfilePhotoFavoriteRequest
    {
        public readonly int CharacterId;
        public readonly bool IsFavorite;

        internal CharacterProfilePhotoFavoriteRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            IsFavorite = br.ReadBoolean();
        }
    }
}
