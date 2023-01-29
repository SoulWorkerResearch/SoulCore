global using OptionStringKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class OptionStringEntry : IEntry<OptionStringEntry>
{
    public const string TableName = "tb_Option_String";

    public OptionStringKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }

    public OptionStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
    }

    static string IEntry<OptionStringEntry>.TableName => TableName;

    static OptionStringEntry IEntry<OptionStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new OptionStringEntry(reader);
    }
}
