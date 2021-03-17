using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ListReq)]
    public readonly struct CharacterListRequest
    {
        public readonly long SessionKey;

        internal CharacterListRequest(BinaryReader br) => SessionKey = br.ReadInt64();
    }
}