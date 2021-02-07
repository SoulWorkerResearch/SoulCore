using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;
using System.Numerics;

namespace SoulCore.IO.Network.Requests.Gesture
{
    [Request(CategoryCommand.Gesture, GestureCommand.Show)]
    public readonly struct GestureShowRequest
    {
        public readonly uint GestureId;
        public readonly Vector3 Position;
        public readonly float Yaw;
        public readonly float Pitch;

        public GestureShowRequest(BinaryReader br)
        {
            GestureId = br.ReadUInt32();
            Position = br.ReadVector3();
            Yaw = br.ReadSingle();
            Pitch = br.ReadSingle();
        }
    }
}