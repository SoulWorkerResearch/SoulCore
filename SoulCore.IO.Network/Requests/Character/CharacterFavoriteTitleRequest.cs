using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.FavoriteTitle)]
    public readonly struct CharacterFavoriteTitleRequest
    {
        public readonly uint CharacterId;
        public readonly uint TitleId;
        public readonly bool IsFavorite;

        internal CharacterFavoriteTitleRequest(BinaryReader br)
        {
            CharacterId = br.ReadUInt32();
            TitleId = br.ReadUInt32();
            IsFavorite = br.ReadBoolean();
        }
    }
}
