global using QuickChangeKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class QuickChangeEntry : IEntry<QuickChangeEntry>
{
    public const string TableName = "tb_Quick_Change";

    public QuickChangeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }

    public QuickChangeEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
    }

    static string IEntry<QuickChangeEntry>.TableName => TableName;

    static QuickChangeEntry IEntry<QuickChangeEntry>.CreateInstance(BinaryReader reader)
    {
        return new QuickChangeEntry(reader);
    }
}
