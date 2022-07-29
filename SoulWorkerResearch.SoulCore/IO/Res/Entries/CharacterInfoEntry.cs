global using CharacterInfoKeyType = System.UInt16;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record CharacterInfoEntry : ITableEntry<CharacterInfoKeyType>
{
    public const string TableName = "tb_Character_Info";

    public const byte DefaultCostumeCount = 4;
    public const byte DefaultPassiveSkillCount = 20;

    public CharacterInfoKeyType Id { get; }
    public ushort Unknown0 { get; }
    public byte Unknown1 { get; }
    public string Unknown2 { get; }
    public string Unknown3 { get; }
    public string DialogueTalkImgPath { get; }
    public string Token { get; }
    public string Unknown4 { get; }
    public string CutScenePath { get; }
    public string GhostTalkImgPath { get; }
    public uint Unknown5 { get; }
    public uint Unknown6 { get; }
    public uint Unknown7 { get; }
    public uint Unknown8 { get; }
    public uint Unknown9 { get; }
    public uint Unknown10 { get; }
    public uint Unknown11 { get; }
    public uint Unknown12 { get; }
    public uint Unknown13 { get; }
    public ushort Unknown24 { get; }
    public ushort Unknown25 { get; }
    public uint DefaultWeaponId { get; }
    public IReadOnlyList<uint> DefaultCostumeIds { get; }
    public uint ProvideItem { get; }
    public short District { get; }
    public short DistrictPositionX { get; }
    public short DistrictPositionY { get; }
    public short DistrictPositionZ { get; }
    public short MazeId { get; }
    public byte Unknown38 { get; }
    public uint MazeSpawnBoxId { get; }
    public uint StartQuest { get; }
    public uint SkipQuestId { get; }
    public ushort Unknown41 { get; }
    public float Unknown42 { get; }
    public short Unknown43 { get; }
    public ushort Unknown44 { get; }
    public ushort Unknown45 { get; }
    public ushort Unknown46 { get; }
    public ushort Unknown47 { get; }
    public ushort Unknown48 { get; }
    public ushort Unknown49 { get; }
    public float Unknown50 { get; }
    public byte Unknown51 { get; }
    public ushort Unknown52 { get; }
    public ushort Unknown53 { get; }
    public ushort Unknown54 { get; }
    public ushort Unknown55 { get; }
    public ushort Unknown56 { get; }
    public ushort Unknown57 { get; }
    public ushort Unknown58 { get; }
    public ushort Unknown59 { get; }
    public ushort Unknown60 { get; }
    public short Unknown61 { get; }
    public ushort Unknown62 { get; }
    public ushort Unknown63 { get; }
    public ushort Unknown64 { get; }
    public IReadOnlyList<uint> DefaultSkill { get; }
    public uint Unknown77 { get; }
    public uint Unknown78 { get; }
    public uint Unknown79 { get; }
    public uint Unknown80 { get; }
    public uint Unknown81 { get; }
    public uint Unknown82 { get; }
    public uint Unknown83 { get; }
    public uint Unknown84 { get; }
    public ushort Unknown85 { get; }
    public float Unknown86 { get; }
    public uint Unknown87 { get; }
    public uint Unknown88 { get; }
    public ushort Unknown89 { get; }
    public byte Unknown90 { get; }

    public CharacterInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Unknown0 = reader.ReadUInt16();
        Unknown1 = reader.ReadByte();
        Unknown2 = reader.ReadUTF16UnicodeString();
        Unknown3 = reader.ReadUTF16UnicodeString();
        DialogueTalkImgPath = reader.ReadUTF16UnicodeString();
        Token = reader.ReadUTF16UnicodeString();
        Unknown4 = reader.ReadUTF16UnicodeString();
        CutScenePath = reader.ReadUTF16UnicodeString();
        GhostTalkImgPath = reader.ReadUTF16UnicodeString();
        Unknown5 = reader.ReadUInt32();
        Unknown6 = reader.ReadUInt32();
        Unknown7 = reader.ReadUInt32();
        Unknown8 = reader.ReadUInt32();
        Unknown9 = reader.ReadUInt32();
        Unknown10 = reader.ReadUInt32();
        Unknown11 = reader.ReadUInt32();
        Unknown12 = reader.ReadUInt32();
        Unknown13 = reader.ReadUInt32();
        Unknown24 = reader.ReadUInt16();
        Unknown25 = reader.ReadUInt16();
        DefaultWeaponId = reader.ReadUInt32();
        DefaultCostumeIds = reader.ReadUInt32AsArray(DefaultCostumeCount);
        ProvideItem = reader.ReadUInt32();
        District = reader.ReadInt16();
        DistrictPositionX = reader.ReadInt16();
        DistrictPositionY = reader.ReadInt16();
        DistrictPositionZ = reader.ReadInt16();
        MazeId = reader.ReadInt16();
        Unknown38 = reader.ReadByte();
        MazeSpawnBoxId = reader.ReadUInt32();
        StartQuest = reader.ReadUInt32();
        SkipQuestId = reader.ReadUInt32();
        Unknown41 = reader.ReadUInt16();
        Unknown42 = reader.ReadSingle();
        Unknown43 = reader.ReadInt16();
        Unknown44 = reader.ReadUInt16();
        Unknown45 = reader.ReadUInt16();
        Unknown46 = reader.ReadUInt16();
        Unknown47 = reader.ReadUInt16();
        Unknown48 = reader.ReadUInt16();
        Unknown49 = reader.ReadUInt16();
        Unknown50 = reader.ReadSingle();
        Unknown51 = reader.ReadByte();
        Unknown52 = reader.ReadUInt16();
        Unknown53 = reader.ReadUInt16();
        Unknown54 = reader.ReadUInt16();
        Unknown55 = reader.ReadUInt16();
        Unknown56 = reader.ReadUInt16();
        Unknown57 = reader.ReadUInt16();
        Unknown58 = reader.ReadUInt16();
        Unknown59 = reader.ReadUInt16();
        Unknown60 = reader.ReadUInt16();
        Unknown61 = reader.ReadInt16();
        Unknown62 = reader.ReadUInt16();
        Unknown63 = reader.ReadUInt16();
        Unknown64 = reader.ReadUInt16();
        DefaultSkill = reader.ReadUInt32AsArray(DefaultPassiveSkillCount);
        Unknown85 = reader.ReadUInt16();
        Unknown86 = reader.ReadSingle();
        Unknown87 = reader.ReadUInt32();
        Unknown88 = reader.ReadUInt32();
        Unknown89 = reader.ReadUInt16();
        Unknown90 = reader.ReadByte();
    }
}
