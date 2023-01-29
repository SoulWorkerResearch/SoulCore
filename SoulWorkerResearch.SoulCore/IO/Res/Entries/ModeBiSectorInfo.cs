global using ModeBiSectorInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeBiSectorInfoEntry : IEntry<ModeBiSectorInfoEntry>
{
    public const string TableName = "tb_Mode_BI_Sector_Info";

    public ModeBiSectorInfoKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public uint Field2 { get; set; }

    public ModeBiSectorInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt32();
    }

    static string IEntry<ModeBiSectorInfoEntry>.TableName => TableName;

    static ModeBiSectorInfoEntry IEntry<ModeBiSectorInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeBiSectorInfoEntry(reader);
    }
}
