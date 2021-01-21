﻿using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct GateConnectRequest
    {
        public ushort Gate { get; }

        public GateConnectRequest(BinaryReader br) => Gate = br.ReadUInt16();
    }
}