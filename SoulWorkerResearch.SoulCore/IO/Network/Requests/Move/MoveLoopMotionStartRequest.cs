using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Move
{
    [Request(CategoryCommand.Move, MoveCommand.LoopMotionStart)]
    public readonly struct MoveLoopMotionStartRequest
    {
        public readonly int CharacterId;
        public readonly Vector3 Position;
        public readonly float Yaw;
        public readonly uint StartAniId;
        public readonly uint LoopAniId;
        public readonly uint EndAniId;
        public readonly uint IdleAniId;

        public MoveLoopMotionStartRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            Position = br.ReadVector3();
            Yaw = br.ReadSingle();
            StartAniId = br.ReadUInt32();
            LoopAniId = br.ReadUInt32();
            EndAniId = br.ReadUInt32();
            IdleAniId = br.ReadUInt32();
        }
    }
}
