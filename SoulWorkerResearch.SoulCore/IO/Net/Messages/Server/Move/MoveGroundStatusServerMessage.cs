using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveGroundStatusServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.GroundStatus;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveGroundStatusServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Person { get; } = reader.ReadInt32();
    public int OnGround { get; } = reader.ReadInt32();
    public float PosZ { get; } = reader.ReadSingle();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
