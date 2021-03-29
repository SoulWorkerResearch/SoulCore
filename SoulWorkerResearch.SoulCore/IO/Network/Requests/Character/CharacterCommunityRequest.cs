using System;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
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
