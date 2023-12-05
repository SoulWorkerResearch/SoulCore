using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemAddSlotServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.AddSlot;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemAddSlotServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte Check { get; } = reader.ReadByte();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
