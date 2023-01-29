global using CustomizeViewSoundKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomizeViewSoundEntry : IEntry<CustomizeViewSoundEntry>
{
    public const string TableName = "tb_Customize_View_Sound";

    public CustomizeViewSoundKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public string Field6 { get; set; } = string.Empty;
    public string Field7 { get; set; } = string.Empty;
    public string Field8 { get; set; } = string.Empty;
    public string Field9 { get; set; } = string.Empty;
    public string Field10 { get; set; } = string.Empty;

    public CustomizeViewSoundEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUTF16UnicodeString();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUTF16UnicodeString();
        Field10 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CustomizeViewSoundEntry>.TableName => TableName;

    static CustomizeViewSoundEntry IEntry<CustomizeViewSoundEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomizeViewSoundEntry(reader);
    }
}
