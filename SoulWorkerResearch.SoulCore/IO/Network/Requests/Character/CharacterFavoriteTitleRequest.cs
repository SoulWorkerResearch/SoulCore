using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.FavoriteTitle)]
    public readonly struct CharacterFavoriteTitleRequest
    {
        public readonly int CharacterId;
        public readonly uint TitleId;
        public readonly bool IsFavorite;

        internal CharacterFavoriteTitleRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            TitleId = br.ReadUInt32();
            IsFavorite = br.ReadBoolean();
        }
    }
}
