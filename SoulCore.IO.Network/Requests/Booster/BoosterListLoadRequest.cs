﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Booster
{
    [Request(CategoryCommand.Booster, BoosterCommand.ListLoad)]
    public readonly struct BoosterListLoadRequest
    {
        internal BoosterListLoadRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}