using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.CreateReq)]
    public readonly struct CharacterCreateRequest
    {
        internal CharacterCreateRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
