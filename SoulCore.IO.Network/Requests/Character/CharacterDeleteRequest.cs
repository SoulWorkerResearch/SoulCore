using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.DeleteReq)]
    public readonly struct CharacterDeleteRequest
    {
        public readonly int CharacterId;

        internal CharacterDeleteRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}