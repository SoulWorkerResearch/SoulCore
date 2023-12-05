using System.Numerics;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveLoopMotionStartServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.LoopMotionStart;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveLoopMotionStartServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Person { get; } = reader.ReadInt32();
    public LocationValue Location { get; } = new LocationValue(reader);
    public AnimationValue Animation { get; } = new AnimationValue(reader);

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    public readonly struct LocationValue(BinaryReader reader)
    {
        public Vector3 Position { get; } = reader.ReadVector3();
        public float Yaw { get; } = reader.ReadSingle();
    }

    public readonly struct AnimationValue(BinaryReader reader)
    {
        public uint StartId { get; } = reader.ReadUInt32();
        public uint LoopId { get; } = reader.ReadUInt32();
        public uint EndId { get; } = reader.ReadUInt32();
        public uint IdleId { get; } = reader.ReadUInt32();
    }

    #endregion DataTypes
}
