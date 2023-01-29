global using EchelonKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class EchelonEntry : IEntry<EchelonEntry>
{
    public const string TableName = "tb_Echelon";

    public EchelonKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public string Field3 { get; set; } = string.Empty;
    public string Field4 { get; set; } = string.Empty;
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }
    public byte Field7 { get; set; }
    public uint Field8 { get; set; }
    public uint Field9 { get; set; }
    public ushort Field10 { get; set; }
    public byte Field11 { get; set; }

    public EchelonEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt16();
        Field11 = reader.ReadByte();
    }

    static string IEntry<EchelonEntry>.TableName => TableName;

    static EchelonEntry IEntry<EchelonEntry>.CreateInstance(BinaryReader reader)
    {
        return new EchelonEntry(reader);
    }
}
