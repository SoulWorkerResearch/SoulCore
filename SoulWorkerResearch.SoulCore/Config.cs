namespace SoulWorkerResearch.SoulCore;

public static class Config
{
    #region Constants

    public const ushort TokenSize = 1025;

    public const ushort PacketHeaderMagic = 0x0020;
    public const byte PacketHeaderMagic0 = PacketHeaderMagic >> 0;
    public const byte PacketHeaderMagic1 = PacketHeaderMagic >> 8;

    public const byte ClothesWithBoochesCount = 5;
    public const byte PerItemBoochesCount = 3;
    public const byte PerItemStatsCount = 5;
    public const byte PartyMembersCount = 4;
    public const byte ForceMembersCount = 8;
    public const byte SkillsInSequenceCount = 3;
    public const byte SkillsInQuickSlotsCount = QuickSlotsCount * SkillsInSequenceCount;
    public const byte ClassesCount = 9;
    public const byte MaxPersonsCount = ClassesCount;
    public const byte MinCharacterNameLength = 2;
    public const byte MaxCharacterNameLength = 12;

    public const byte QuickSlotsCount = 6;
    public const byte QuickSlotsCubeCount = 4;

    public const byte EquipableFashionStorageMaxCapacity = 14;
    public const byte EquipableGearStorageMaxCapacity = 10;

    public const byte PacketHeaderSize = 5;
    public const byte OptionsCount = 64;

    public const byte PacketOpcodeSize = sizeof(ushort);

    public const float DefaultAttackSpeed = 1.0f;
    public const float DefaultMoveSpeed = 1.0f;

    #endregion Constants

    #region Types

    public static readonly Type PacketOpcodeType = typeof(ushort);

    #endregion Types
}
