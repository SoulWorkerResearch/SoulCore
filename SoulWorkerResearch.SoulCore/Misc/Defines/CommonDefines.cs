using System;

namespace SoulWorkerResearch.SoulCore
{
    public static class CommonDefines
    {
        public const ushort TokenSize = 1025;
        public const byte PacketHeaderMagic1 = 0x2;
        public const byte PacketHeaderMagic2 = 0x0;

        public const byte ClothesWithBoochesCount = 5;
        public const byte PerItemBoochesCount = 3;
        public const byte PerItemStatsCount = 5;
        public const byte PartyMembersCount = 4;
        public const byte ForceMembersCount = 8;
        public const byte SkillsInSequenceCount = 3;
        public const byte SkillsInQuickSlotsCount = QuickSlotsCount * SkillsInSequenceCount;
        public const byte ClassesCount = 9;
        public const byte MinCharacterNameLength = 2;
        public const byte MaxCharacterNameLength = 12;

        public const byte QuickSlotsCount = 6;
        public const byte QuickSlotsCubeCount = 4;

        public const byte EquipableFashionStorageMaxCapacity = 14;
        public const byte EquipableGearStorageMaxCapacity = 10;

        public const byte PacketHeaderSize = 5;
        public const byte OptionsCount = 64;

        public static readonly Type PacketOpcodeType = typeof(ushort);
        public const byte PacketOpcodeSize = sizeof(ushort);
    }
}
