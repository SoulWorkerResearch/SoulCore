﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.KickOut)]
    public readonly struct PartyKickOutRequest
    {
        public readonly int CharacterId;

        internal PartyKickOutRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}