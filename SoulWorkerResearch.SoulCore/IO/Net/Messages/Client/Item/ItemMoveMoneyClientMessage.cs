using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemMoveMoneyClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.MoveMoney;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemMoveMoneyClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte TargetType { get; init; }
    public ulong Money { get; init; }

    #endregion Body

    #region Constructors

    internal ItemMoveMoneyClientMessage(BinaryReader reader)
    {
        TargetType = reader.ReadByte();
        Money = reader.ReadUInt64();
    }

    #endregion Constructors
}
