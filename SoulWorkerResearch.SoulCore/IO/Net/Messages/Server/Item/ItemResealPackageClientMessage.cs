using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemLineUpClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.LineUp;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemLineUpClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Constructors

    internal ItemLineUpClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemUpdateQuickSlotCardClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.UpdateQuickslotCard;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemUpdateQuickSlotCardClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemUpdateQuickSlotCardClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemUpdateQuickSlotItemClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.UpdateQuickslotItem;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemUpdateQuickSlotItemClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemUpdateQuickSlotItemClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemReloadUpdateCashClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.UpdateCash;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemReloadUpdateCashClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemReloadUpdateCashClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemMazeRewardItemClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.MazeRewardItem;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemMazeRewardItemClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemMazeRewardItemClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemAppearanceEquipClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.AppearanceEquip;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemAppearanceEquipClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemAppearanceEquipClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemNameChangeClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.NameChange;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemNameChangeClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemNameChangeClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemUseSelectClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.UseSelect;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemUseSelectClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemUseSelectClientMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    #endregion DataTypes
}

[ClientMessage(Group, Command)]
public readonly struct ItemResealPackageClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.ResealPackage;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemResealPackageClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Person { get; init; }
    public IReadOnlyCollection<SlotInfo> Slots { get; init; }

    #endregion Body

    #region Constructors

    internal ItemResealPackageClientMessage(BinaryReader reader)
    {
        Person = reader.ReadInt32();

        var count = reader.ReadByte();
        Slots = Enumerable.Range(0, count).Select(_ => new SlotInfo(reader)).ToArray();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    public readonly struct SlotInfo(BinaryReader reader)
    {
        public byte InvenType { get; } = reader.ReadByte();
        public ushort SlotPos { get; } = reader.ReadUInt16();
    }

    #endregion DataTypes
}
