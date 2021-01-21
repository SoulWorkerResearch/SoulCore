using SoulCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt16;

    [Table("tb_Character_Info")]
    public sealed class CharacterInfoEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public ushort Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public string Unknown2 { get; set; }
        public string Unknown3 { get; set; }
        public string DialogueTalkImgPath { get; set; }
        public string Token { get; set; }
        public string Unknown4 { get; set; }
        public string CutScenePath { get; set; }
        public string GhostTalkImgPath { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public uint Unknown13 { get; set; }
        public ushort Unknown24 { get; set; }
        public ushort Unknown25 { get; set; }
        public uint DefaultWeaponId { get; set; }
        public List<uint> DefaultCostumeIds { get; set; }
        public uint ProvideItem { get; set; }
        public short District { get; set; }
        public short DistrictPositionX { get; set; }
        public short DistrictPositionY { get; set; }
        public short DistrictPositionZ { get; set; }
        public short MazeId { get; set; }
        public byte Unknown38 { get; set; }
        public uint MazeSpawnBoxId { get; set; }
        public uint StartQuest { get; set; }
        public uint SkipQuestId { get; set; }
        public ushort Unknown41 { get; set; }
        public float Unknown42 { get; set; }
        public short Unknown43 { get; set; }
        public ushort Unknown44 { get; set; }
        public ushort Unknown45 { get; set; }
        public ushort Unknown46 { get; set; }
        public ushort Unknown47 { get; set; }
        public ushort Unknown48 { get; set; }
        public ushort Unknown49 { get; set; }
        public float Unknown50 { get; set; }
        public byte Unknown51 { get; set; }
        public ushort Unknown52 { get; set; }
        public ushort Unknown53 { get; set; }
        public ushort Unknown54 { get; set; }
        public ushort Unknown55 { get; set; }
        public ushort Unknown56 { get; set; }
        public ushort Unknown57 { get; set; }
        public ushort Unknown58 { get; set; }
        public ushort Unknown59 { get; set; }
        public ushort Unknown60 { get; set; }
        public short Unknown61 { get; set; }
        public ushort Unknown62 { get; set; }
        public ushort Unknown63 { get; set; }
        public ushort Unknown64 { get; set; }
        public List<uint> DefaultSkill { get; set; }
        public uint Unknown77 { get; set; }
        public uint Unknown78 { get; set; }
        public uint Unknown79 { get; set; }
        public uint Unknown80 { get; set; }
        public uint Unknown81 { get; set; }
        public uint Unknown82 { get; set; }
        public uint Unknown83 { get; set; }
        public uint Unknown84 { get; set; }
        public ushort Unknown85 { get; set; }
        public float Unknown86 { get; set; }
        public uint Unknown87 { get; set; }
        public uint Unknown88 { get; set; }
        public ushort Unknown89 { get; set; }
        public byte Unknown90 { get; set; }

        public CharacterInfoEntity(BinaryReader br)
        {
            Id = br.ReadUInt16();
            Unknown0 = br.ReadUInt16();
            Unknown1 = br.ReadByte();
            Unknown2 = br.ReadByteLengthUnicodeString();
            Unknown3 = br.ReadByteLengthUnicodeString();
            DialogueTalkImgPath = br.ReadByteLengthUnicodeString();
            Token = br.ReadByteLengthUnicodeString();
            Unknown4 = br.ReadByteLengthUnicodeString();
            CutScenePath = br.ReadByteLengthUnicodeString();
            GhostTalkImgPath = br.ReadByteLengthUnicodeString();
            Unknown5 = br.ReadUInt32();
            Unknown6 = br.ReadUInt32();
            Unknown7 = br.ReadUInt32();
            Unknown8 = br.ReadUInt32();
            Unknown9 = br.ReadUInt32();
            Unknown10 = br.ReadUInt32();
            Unknown11 = br.ReadUInt32();
            Unknown12 = br.ReadUInt32();
            Unknown13 = br.ReadUInt32();
            Unknown24 = br.ReadUInt16();
            Unknown25 = br.ReadUInt16();
            DefaultWeaponId = br.ReadUInt32();
            DefaultCostumeIds = br.ReadUInt32Enumerable(DefaultCostumesCount).ToList();
            ProvideItem = br.ReadUInt32();
            District = br.ReadInt16();
            DistrictPositionX = br.ReadInt16();
            DistrictPositionY = br.ReadInt16();
            DistrictPositionZ = br.ReadInt16();
            MazeId = br.ReadInt16();
            Unknown38 = br.ReadByte();
            MazeSpawnBoxId = br.ReadUInt32();
            StartQuest = br.ReadUInt32();
            SkipQuestId = br.ReadUInt32();
            Unknown41 = br.ReadUInt16();
            Unknown42 = br.ReadSingle();
            Unknown43 = br.ReadInt16();
            Unknown44 = br.ReadUInt16();
            Unknown45 = br.ReadUInt16();
            Unknown46 = br.ReadUInt16();
            Unknown47 = br.ReadUInt16();
            Unknown48 = br.ReadUInt16();
            Unknown49 = br.ReadUInt16();
            Unknown50 = br.ReadSingle();
            Unknown51 = br.ReadByte();
            Unknown52 = br.ReadUInt16();
            Unknown53 = br.ReadUInt16();
            Unknown54 = br.ReadUInt16();
            Unknown55 = br.ReadUInt16();
            Unknown56 = br.ReadUInt16();
            Unknown57 = br.ReadUInt16();
            Unknown58 = br.ReadUInt16();
            Unknown59 = br.ReadUInt16();
            Unknown60 = br.ReadUInt16();
            Unknown61 = br.ReadInt16();
            Unknown62 = br.ReadUInt16();
            Unknown63 = br.ReadUInt16();
            Unknown64 = br.ReadUInt16();
            DefaultSkill = br.ReadUInt32Enumerable(DefaultPassiveSkillCount).ToList();
            Unknown85 = br.ReadUInt16();
            Unknown86 = br.ReadSingle();
            Unknown87 = br.ReadUInt32();
            Unknown88 = br.ReadUInt32();
            Unknown89 = br.ReadUInt16();
            Unknown90 = br.ReadByte();
        }

        private const byte DefaultCostumesCount = 4;
        private const byte DefaultPassiveSkillCount = 20;
    }
}
