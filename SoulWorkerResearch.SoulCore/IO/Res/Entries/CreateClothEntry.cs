global using CreateClothKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CreateClothEntry : IEntry<CreateClothEntry>
{
    public const string TableName = "tb_Create_Cloth";

    public CreateClothKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;

    public CreateClothEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<CreateClothEntry>.TableName => TableName;

    static CreateClothEntry IEntry<CreateClothEntry>.CreateInstance(BinaryReader reader)
    {
        return new CreateClothEntry(reader);
    }
}
