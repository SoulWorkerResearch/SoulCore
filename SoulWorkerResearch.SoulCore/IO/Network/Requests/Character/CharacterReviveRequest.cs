using System;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
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
