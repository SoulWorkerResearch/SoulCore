using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.World;

[ClientMessage(Group, Command)]
public readonly struct WorldCurrentDateClientMessage() : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.World;
    public const WorldOpcode Command = WorldOpcode.CurDate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(WorldCurrentDateClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public DateTime Value { get; init; } = DateTime.Now;

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Value.Ticks);
        writer.Write(Value.Year);
        writer.Write(Value.Month);
        writer.Write(Value.Day);
        writer.Write(Value.Hour);
        writer.Write(Value.Minute);
        writer.Write(Value.Second);
        writer.Write(Convert.ToUInt16(Value.IsDaylightSavingTime()));
    }

    #endregion IBinaryConvertibleMessage
}
