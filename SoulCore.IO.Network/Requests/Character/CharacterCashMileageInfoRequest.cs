﻿using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Character, CharacterCommand.CashMileageInfo)]
    public readonly struct CharacterCashMileageInfoRequest
    {
        internal CharacterCashMileageInfoRequest(BinaryReader _)
        {
        }
    }
}
