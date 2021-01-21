﻿using SoulCore.Types;

namespace SoulCore.IO.Network.Responses
{
    public sealed record ChatMessageResponse
    {
        public int Character { get; init; }
        public ChatType Chat { get; init; }
        public string Message { get; init; } = default!;
    }
}
