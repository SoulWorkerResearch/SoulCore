using System;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.RepresentativeCheck)]
    public readonly struct CharacterRepresentativeCheckRequest
    {
        internal CharacterRepresentativeCheckRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
