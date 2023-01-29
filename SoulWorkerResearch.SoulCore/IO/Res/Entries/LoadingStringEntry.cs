global using LoadingStringKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LoadingStringEntry : IEntry<LoadingStringEntry>
{
    public const string TableName = "tb_Loading_String";

    public LoadingStringKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }

    public LoadingStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
    }

    static string IEntry<LoadingStringEntry>.TableName => TableName;

    static LoadingStringEntry IEntry<LoadingStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new LoadingStringEntry(reader);
    }
}
