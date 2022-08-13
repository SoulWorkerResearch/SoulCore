using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveLoopMotionStartServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.LoopMotionStart;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveLoopMotionStartServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public LocationValue Location { get; }
    public AnimationValue Animation { get; }

    #endregion Body

    #region Constructors

    internal MoveLoopMotionStartServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        Location = new(reader);
        Animation = new(reader);
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region Types

    public readonly struct LocationValue
    {
        public Vector3 Position { get; }
        public float Yaw { get; }

        public LocationValue(BinaryReader reader)
        {
            Position = reader.ReadVector3();
            Yaw = reader.ReadSingle();
        }
    }

    public readonly struct AnimationValue
    {
        public uint StartId { get; }
        public uint LoopId { get; }
        public uint EndId { get; }
        public uint IdleId { get; }

        public AnimationValue(BinaryReader reader)
        {
            StartId = reader.ReadUInt32();
            LoopId = reader.ReadUInt32();
            EndId = reader.ReadUInt32();
            IdleId = reader.ReadUInt32();
        }
    }

    #endregion Types
}
