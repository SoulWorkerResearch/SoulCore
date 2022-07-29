using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemLineUpClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.LineUp;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemLineUpClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal ItemLineUpClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemUpdateQuickSlotCardClientMessage
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

    internal ItemUpdateQuickSlotCardClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemUpdateQuickSlotItemClientMessage
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

    internal ItemUpdateQuickSlotItemClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemReloadUpdateCashClientMessage
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

    internal ItemReloadUpdateCashClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemMazeRewardItemClientMessage
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

    internal ItemMazeRewardItemClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemAppearanceEquipClientMessage
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

    internal ItemAppearanceEquipClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemNameChangeClientMessage
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

    internal ItemNameChangeClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemUseSelectClientMessage
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

    internal ItemUseSelectClientMessage(BinaryReader reader) => throw new NotImplementedException();

    #endregion Constructors

    #region Types

    #endregion Types
}

[ClientMessage(Group, Command)]
public readonly struct ItemResealPackageClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.ResealPackage;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemResealPackageClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; init; }
    public IEnumerable<SlotInfo> Slots { get; init; }

    #endregion Body

    #region Constructors

    internal ItemResealPackageClientMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();

        var count = reader.ReadByte();
        Slots = Enumerable.Range(0, count).Select(_ => new SlotInfo(reader)).ToArray();
    }

    #endregion Constructors

    #region Types

    public readonly struct SlotInfo
    {
        #region Body

        public byte InvenType { get; init; }
        public ushort SlotPos { get; init; }

        #endregion Body

        #region Constructors

        public SlotInfo(BinaryReader reader)
        {
            InvenType = reader.ReadByte();
            SlotPos = reader.ReadUInt16();
        }

        #endregion Constructors
    };

    #endregion Types
}
