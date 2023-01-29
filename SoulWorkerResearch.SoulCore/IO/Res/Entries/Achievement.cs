global using AchievementKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AchievementEntry : IEntry<AchievementEntry>
{
    public const string TableName = "tb_Achievement";

    public AchievementKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public byte Field3 { get; set; }
    public ushort Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;
    public ushort Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public uint Field13 { get; set; }
    public uint Field14 { get; set; }
    public byte Field15 { get; set; }
    public byte Field16 { get; set; }
    public uint Field17 { get; set; }
    public uint Field18 { get; set; }
    public byte Field19 { get; set; }
    public byte Field20 { get; set; }

    public AchievementEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt32();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadUInt32();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadByte();
        Field20 = reader.ReadByte();
    }

    static string IEntry<AchievementEntry>.TableName => TableName;

    static AchievementEntry IEntry<AchievementEntry>.CreateInstance(BinaryReader reader)
    {
        return new AchievementEntry(reader);
    }
}
