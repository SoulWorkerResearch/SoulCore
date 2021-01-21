﻿using SoulCore.IO.Network.Responses.Shared;
using SoulCore.Types;

namespace SoulCore.IO.Network.Responses
{
    public sealed partial record UserCharacterForServerResponse
    {
        public readonly struct Entity
        {
            public ushort Id { get; init; }
            public SEndPointSharedResponse EndPoint { get; init; }
            public string Name { get; init; }
            public GateStatus Status { get; init; }
            public uint PlayersOnlineCount { get; init; }
            public byte CharactersCount { get; init; }
        }
    }
}