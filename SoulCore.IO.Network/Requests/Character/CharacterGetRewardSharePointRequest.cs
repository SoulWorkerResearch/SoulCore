﻿using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
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