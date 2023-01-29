global using AdvancinghelixKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AdvancinghelixEntry : IEntry<AdvancinghelixEntry>
{
    public const string TableName = "tb_AdvancingHelix";

    public AdvancinghelixKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public ushort Field3 { get; set; }
    public uint Field4 { get; set; }
    public ushort Field5 { get; set; }

    public AdvancinghelixEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt16();
    }

    static string IEntry<AdvancinghelixEntry>.TableName => TableName;

    static AdvancinghelixEntry IEntry<AdvancinghelixEntry>.CreateInstance(BinaryReader reader)
    {
        return new AdvancinghelixEntry(reader);
    }
}
