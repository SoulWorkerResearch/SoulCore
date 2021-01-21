using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request]
    public readonly struct CharacterInfoRequest
    {
        public int CharacterId { get; }
        public byte Unknown1 { get; }

        public CharacterInfoRequest(BinaryReader br) => (CharacterId, Unknown1) = (br.ReadInt32(), br.ReadByte());
    }
}