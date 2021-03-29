using System;
using System.IO;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.GetRewardSharePoint)]
    public readonly struct CharacterGetRewardSharePointRequest
    {
        internal CharacterGetRewardSharePointRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
