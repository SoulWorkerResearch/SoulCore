global using AppearanceKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AppearanceEntry : IEntry<AppearanceEntry>
{
    public const string TableName = "tb_Appearance";

    public AppearanceKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;
    public byte Field6 { get; set; }

    public AppearanceEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadByte();
    }

    static string IEntry<AppearanceEntry>.TableName => TableName;

    static AppearanceEntry IEntry<AppearanceEntry>.CreateInstance(BinaryReader reader)
    {
        return new AppearanceEntry(reader);
    }
}
