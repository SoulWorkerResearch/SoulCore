using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public sealed record CharacterSpecialOptionListUpdateRequest
    {
        public int Character { get; }

        public CharacterSpecialOptionListUpdateRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
