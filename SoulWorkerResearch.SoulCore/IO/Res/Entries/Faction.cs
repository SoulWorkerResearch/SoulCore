global using FactionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class FactionEntry : IEntry<FactionEntry>
{
    public const string TableName = "tb_Faction";

    public FactionKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }

    public FactionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
    }

    static string IEntry<FactionEntry>.TableName => TableName;

    static FactionEntry IEntry<FactionEntry>.CreateInstance(BinaryReader reader)
    {
        return new FactionEntry(reader);
    }
}
