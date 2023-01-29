global using LoadingKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LoadingEntry : IEntry<LoadingEntry>
{
    public const string TableName = "tb_Loading";

    public LoadingKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }

    public LoadingEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
    }

    static string IEntry<LoadingEntry>.TableName => TableName;

    static LoadingEntry IEntry<LoadingEntry>.CreateInstance(BinaryReader reader)
    {
        return new LoadingEntry(reader);
    }
}
