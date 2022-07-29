using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemUseClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Use;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemUseClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte InvenType { get; init; }
    public ushort SlotPos { get; init; }
    public SerialValue Serial { get; init; }
    public byte Count { get; init; }

    #endregion Body

    #region Constructors

    internal ItemUseClientMessage(BinaryReader reader)
    {
        InvenType = reader.ReadByte();
        SlotPos = reader.ReadUInt16();
        Serial = new(reader);
        Count = reader.ReadByte();
    }

    #endregion Constructors
}
