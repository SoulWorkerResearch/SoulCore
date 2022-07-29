using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemCombineClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Combine;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemCombineClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ItemMoveClientMessage.InfoValue Info { get; init; }
    public ushort Count { get; init; }

    #endregion Body

    #region Constructors

    internal ItemCombineClientMessage(BinaryReader reader)
    {
        Info = new(reader);
        Count = reader.ReadUInt16();
    }

    #endregion Constructors
}
