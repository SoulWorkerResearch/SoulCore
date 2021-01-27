using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
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
