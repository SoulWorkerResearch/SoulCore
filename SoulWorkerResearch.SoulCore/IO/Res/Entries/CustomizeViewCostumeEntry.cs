global using CustomizeViewCostumeKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomizeViewCostumeEntry : IEntry<CustomizeViewCostumeEntry>
{
    public const string TableName = "tb_Customize_View_Costume";

    public CustomizeViewCostumeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public uint Field12 { get; set; }
    public string Field13 { get; set; } = string.Empty;

    public CustomizeViewCostumeEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt32();
        Field13 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CustomizeViewCostumeEntry>.TableName => TableName;

    static CustomizeViewCostumeEntry IEntry<CustomizeViewCostumeEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomizeViewCostumeEntry(reader);
    }
}
