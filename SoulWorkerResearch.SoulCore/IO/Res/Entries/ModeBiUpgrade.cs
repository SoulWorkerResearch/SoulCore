global using ModeBiUpgradeKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeBiUpgradeEntry : IEntry<ModeBiUpgradeEntry>
{
    public const string TableName = "tb_Mode_BI_Upgrade";

    public ModeBiUpgradeKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public string Field8 { get; set; } = string.Empty;

    public ModeBiUpgradeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ModeBiUpgradeEntry>.TableName => TableName;

    static ModeBiUpgradeEntry IEntry<ModeBiUpgradeEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeBiUpgradeEntry(reader);
    }
}
