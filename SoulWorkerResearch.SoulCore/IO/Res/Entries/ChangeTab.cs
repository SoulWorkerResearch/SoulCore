global using ChangeTabKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ChangeTabEntry : IEntry<ChangeTabEntry>
{
    public const string TableName = "tb_change_tab";

    public ChangeTabKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }

    public ChangeTabEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
    }

    static string IEntry<ChangeTabEntry>.TableName => TableName;

    static ChangeTabEntry IEntry<ChangeTabEntry>.CreateInstance(BinaryReader reader)
    {
        return new ChangeTabEntry(reader);
    }
}
