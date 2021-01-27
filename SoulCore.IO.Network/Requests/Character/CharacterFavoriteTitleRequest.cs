using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
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
