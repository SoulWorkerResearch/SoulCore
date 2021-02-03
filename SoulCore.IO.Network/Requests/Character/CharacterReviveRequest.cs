using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ReviveReq)]
    public readonly struct CharacterReviveRequest
    {
        internal CharacterReviveRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
