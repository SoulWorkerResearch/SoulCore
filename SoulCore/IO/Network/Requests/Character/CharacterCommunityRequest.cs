using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.Community)]
    public readonly struct CharacterCommunityRequest
    {
        internal CharacterCommunityRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
