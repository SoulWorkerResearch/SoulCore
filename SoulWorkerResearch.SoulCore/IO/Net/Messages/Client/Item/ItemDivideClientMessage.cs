using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemDivideClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Divide;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemDivideClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte SrcInvenType { get; init; }
    public int SrcItemId { get; init; }
    public ushort SrcSlotPos { get; init; }
    public byte DestInvenType { get; init; }
    public ushort DestSlotPos { get; init; }
    public ushort Count { get; init; }

    #endregion Body

    #region Constructors

    internal ItemDivideClientMessage(BinaryReader reader)
    {
        SrcInvenType = reader.ReadByte();
        SrcItemId = reader.ReadInt32();
        SrcSlotPos = reader.ReadUInt16();
        DestInvenType = reader.ReadByte();
        DestSlotPos = reader.ReadUInt16();
        Count = reader.ReadUInt16();
    }

    #endregion Constructors

    #region Types

    #endregion Types
}
