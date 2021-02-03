using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses.Shared;
using System.IO;
using System.Numerics;

namespace SoulCore.IO.Network.Requests
{
    [Request(CategoryCommand.Move, MoveCommand.Stop)]
    public readonly struct MoveStopRequest
    {
        public readonly int CharacterId;
        public readonly MapIdPacketSharedStructure MapId;
        public readonly Vector3 Position;
        public readonly float Yaw;
        public readonly float Pitch;
        public readonly byte CheckCanMove;

        public MoveStopRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            MapId = new(br);
            Position = br.ReadVector3();
            Yaw = br.ReadSingle();
            Pitch = br.ReadSingle();
            CheckCanMove = br.ReadByte();
        }
    }
}