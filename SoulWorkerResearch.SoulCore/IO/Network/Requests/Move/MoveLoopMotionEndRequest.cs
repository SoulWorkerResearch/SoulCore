using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Move
{
    [Request(CategoryCommand.Move, MoveCommand.LoopMotionEnd)]
    public readonly struct MoveLoopMotionEndRequest
    {
        public readonly int CharacterId;

        public MoveLoopMotionEndRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}
