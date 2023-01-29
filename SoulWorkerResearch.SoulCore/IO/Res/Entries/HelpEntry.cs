global using HelpKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class HelpEntry : IEntry<HelpEntry>
{
    public const string TableName = "tb_Help";

    public HelpKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;
    public uint Field6 { get; set; }

    public HelpEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUInt32();
    }

    static string IEntry<HelpEntry>.TableName => TableName;

    static HelpEntry IEntry<HelpEntry>.CreateInstance(BinaryReader reader)
    {
        return new HelpEntry(reader);
    }
}
