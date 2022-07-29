using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemAddSlotClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.AddSlot;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemAddSlotClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte Check { get; init; }

    #endregion Body

    #region Constructors

    internal ItemAddSlotClientMessage(BinaryReader reader) => Check = reader.ReadByte();

    #endregion Constructors
}
