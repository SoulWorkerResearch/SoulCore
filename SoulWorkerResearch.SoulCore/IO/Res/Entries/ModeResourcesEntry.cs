global using ModeResourcesKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeResourcesEntry : IEntry<ModeResourcesEntry>
{
    public const string TableName = "tb_Mode_Resources";

    public ModeResourcesKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public float Field8 { get; set; }
    public float Field9 { get; set; }
    public float Field10 { get; set; }

    public ModeResourcesEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadSingle();
        Field9 = reader.ReadSingle();
        Field10 = reader.ReadSingle();
    }

    static string IEntry<ModeResourcesEntry>.TableName => TableName;

    static ModeResourcesEntry IEntry<ModeResourcesEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeResourcesEntry(reader);
    }
}
