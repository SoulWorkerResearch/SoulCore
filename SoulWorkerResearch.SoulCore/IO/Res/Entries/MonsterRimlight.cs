global using MonsterRimlightKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MonsterRimlightEntry : IEntry<MonsterRimlightEntry>
{
    public const string TableName = "tb_Monster_RimLight";

    public MonsterRimlightKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public float Field5 { get; set; }

    public MonsterRimlightEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadSingle();
    }

    static string IEntry<MonsterRimlightEntry>.TableName => TableName;

    static MonsterRimlightEntry IEntry<MonsterRimlightEntry>.CreateInstance(BinaryReader reader)
    {
        return new MonsterRimlightEntry(reader);
    }
}
