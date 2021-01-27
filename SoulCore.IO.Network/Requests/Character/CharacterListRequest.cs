using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.List)]
    public readonly struct CharacterListRequest
    {
        public readonly long SessionKey;

        internal CharacterListRequest(BinaryReader br)
        {
            SessionKey = br.ReadInt64();
        }
    }
}
