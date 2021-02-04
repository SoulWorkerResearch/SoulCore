using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Move
{
    [Request(CategoryCommand.Move, MoveCommand.LoopMotionEnd)]
    public readonly struct MoveLoopMotionEndRequest
    {
        public readonly int CharacterId;

        public MoveLoopMotionEndRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}