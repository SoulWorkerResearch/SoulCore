using System;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
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
