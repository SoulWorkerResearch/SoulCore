using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct MovementLoopMotionEndBroadcastRequest
    {
        public int Character { get; }

        public MovementLoopMotionEndBroadcastRequest(BinaryReader br) => Character = br.ReadInt32();
    }
}
