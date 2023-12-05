using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Move;

[ClientMessage(Group, Command)]
[ServerMessage(Group, Command)]
public readonly struct MoveJumpBidirectionalMessage : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.Jump;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveJumpBidirectionalMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public PositionValue Position { get; }
    public int JumpingMove { get; }
    public int JumpDrop { get; }
    public int BonusJump { get; }

    #endregion Body

    #region Constructors

    internal MoveJumpBidirectionalMessage(BinaryReader reader)
    {
        Position = new(reader);
        JumpingMove = reader.ReadInt32();
        JumpDrop = reader.ReadInt32();
        BonusJump = reader.ReadInt32();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Position);
        writer.Write(JumpingMove);
        writer.Write(JumpDrop);
        writer.Write(BonusJump);
    }

    #endregion IBinaryOutcomingMessage
}
