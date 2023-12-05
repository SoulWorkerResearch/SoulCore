using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Move;

[ClientMessage(Group, Command)]
[ServerMessage(Group, Command)]
public readonly struct MoveMoveBidirectionalMessage : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.Move;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveMoveBidirectionalMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public PositionValue Position { get; }
    public bool IsRun { get; }
    public float Pitch { get; }
    public float MoveSpeed { get; }
    public byte ChangeMotion { get; }
    public bool ShouldUpdatePos { get; }

    #endregion Body

    internal MoveMoveBidirectionalMessage(BinaryReader reader)
    {
        Position = new(reader);
        IsRun = reader.ReadBoolean();
        Pitch = reader.ReadSingle();
        MoveSpeed = reader.ReadSingle();
        ChangeMotion = reader.ReadByte();
        ShouldUpdatePos = reader.ReadBoolean();
    }

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Position);
        writer.Write(IsRun);
        writer.Write(Pitch);
        writer.Write(MoveSpeed);
        writer.Write(ChangeMotion);
        writer.Write(ShouldUpdatePos);
    }

    #endregion IBinaryOutcomingMessage
}
