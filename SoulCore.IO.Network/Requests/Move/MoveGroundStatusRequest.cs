﻿using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Move
{
    [Request(CategoryCommand.Move, MoveCommand.GroundStatus)]
    public readonly struct MoveGroundStatusRequest
    {
        public readonly int CharacterId;
        public readonly int OnGround;
        public readonly float PosZ;

        public MoveGroundStatusRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            OnGround = br.ReadInt32();
            PosZ = br.ReadSingle();
        }
    }
}