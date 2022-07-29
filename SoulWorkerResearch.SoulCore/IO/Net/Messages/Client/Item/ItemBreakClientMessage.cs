using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemBreakClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Break;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemBreakClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte InvenType { get; init; }
    public ushort SlotPos { get; init; }
    public SerialValue Serial { get; init; }
    public uint Count { get; init; }

    #endregion Body

    #region Constructors

    internal ItemBreakClientMessage(BinaryReader reader)
    {
        InvenType = reader.ReadByte();
        SlotPos = reader.ReadUInt16();
        Serial = new(reader);
        Count = reader.ReadUInt32();
    }

    #endregion Constructors
}
