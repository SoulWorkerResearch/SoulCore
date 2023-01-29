global using AchievementBeginKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AchievementBeginEntry : IEntry<AchievementBeginEntry>
{
    public const string TableName = "tb_Achievement_begin";

    public AchievementBeginKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }

    public AchievementBeginEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
    }

    static string IEntry<AchievementBeginEntry>.TableName => TableName;

    static AchievementBeginEntry IEntry<AchievementBeginEntry>.CreateInstance(BinaryReader reader)
    {
        return new AchievementBeginEntry(reader);
    }
}
