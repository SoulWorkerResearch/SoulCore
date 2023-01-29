global using HelpPopupKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class HelpPopupEntry : IEntry<HelpPopupEntry>
{
    public const string TableName = "tb_Help_PopUp";

    public HelpPopupKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;

    public HelpPopupEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<HelpPopupEntry>.TableName => TableName;

    static HelpPopupEntry IEntry<HelpPopupEntry>.CreateInstance(BinaryReader reader)
    {
        return new HelpPopupEntry(reader);
    }
}
