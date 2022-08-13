using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Gesture;

[ServerMessage(Group, Command)]
public readonly struct GestureShowServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Gesture;
    public const GestureOpcode Command = GestureOpcode.Show;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(GestureShowServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public uint GestureId { get; }
    public LocationValue Location { get; }

    #endregion Body

    #region Constructors

    internal GestureShowServerMessage(BinaryReader reader)
    {
        GestureId = reader.ReadUInt32();
        Location = new(reader);
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region Types

    public readonly struct LocationValue
    {
        #region Body

        public Vector3 Position { get; }
        public float Yaw { get; }
        public float Pitch { get; }

        #endregion Body

        #region Constructors

        public LocationValue(BinaryReader reader)
        {
            Position = reader.ReadVector3();
            Yaw = reader.ReadSingle();
            Pitch = reader.ReadSingle();
        }

        #endregion Constructors
    }

    #endregion Types
}
