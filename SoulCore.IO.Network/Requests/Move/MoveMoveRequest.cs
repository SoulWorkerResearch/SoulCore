using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses.Shared;
using System.IO;
using System.Numerics;

namespace SoulCore.IO.Network.Requests
{
    [Request(CategoryCommand.Move, MoveCommand.Move)]
    public readonly struct MoveMoveRequest
    {
        public readonly int CharacterId;
        public readonly MapIdPacketSharedStructure MapId;
        public readonly Vector3 Position;
        public readonly float Yaw;
        public readonly Vector2 TargetPosition;
        public readonly byte RunBit;
        public readonly float Pitch;
        public readonly float MoveSpeed;
        public readonly byte ChangeMotion;
        public readonly bool ShouldUpdatePos;

        public MoveMoveRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            MapId = new(br);
            Position = br.ReadVector3();
            Yaw = br.ReadSingle();
            TargetPosition = br.ReadVector2();
            RunBit = br.ReadByte();
            Pitch = br.ReadSingle();
            MoveSpeed = br.ReadSingle();
            ChangeMotion = br.ReadByte();
            ShouldUpdatePos = br.ReadBoolean();
        }
    }
}