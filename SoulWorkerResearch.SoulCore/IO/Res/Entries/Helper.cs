global using HelperKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class HelperEntry : IEntry<HelperEntry>
{
    public const string TableName = "tb_Helper";

    public HelperKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;

    public HelperEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<HelperEntry>.TableName => TableName;

    static HelperEntry IEntry<HelperEntry>.CreateInstance(BinaryReader reader)
    {
        return new HelperEntry(reader);
    }
}
