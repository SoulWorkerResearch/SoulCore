global using PassInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PassInfoEntry : IEntry<PassInfoEntry>
{
    public const string TableName = "tb_Pass_Info";

    public PassInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public byte Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;
    public uint Field9 { get; set; }

    public PassInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUInt32();
    }

    static string IEntry<PassInfoEntry>.TableName => TableName;

    static PassInfoEntry IEntry<PassInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new PassInfoEntry(reader);
    }
}
