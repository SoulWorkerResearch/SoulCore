global using EmoticonKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class EmoticonEntry : IEntry<EmoticonEntry>
{
    public const string TableName = "tb_Emoticon";

    public EmoticonKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;
    public ushort Field6 { get; set; }
    public string Field7 { get; set; } = string.Empty;
    public uint Field8 { get; set; }

    public EmoticonEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUTF16UnicodeString();
        Field8 = reader.ReadUInt32();
    }

    static string IEntry<EmoticonEntry>.TableName => TableName;

    static EmoticonEntry IEntry<EmoticonEntry>.CreateInstance(BinaryReader reader)
    {
        return new EmoticonEntry(reader);
    }
}
