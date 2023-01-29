global using DispatchTypeKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DispatchTypeEntry : IEntry<DispatchTypeEntry>
{
    public const string TableName = "tb_Dispatch_type";

    public DispatchTypeKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public uint Field3 { get; set; }

    public DispatchTypeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUInt32();
    }

    static string IEntry<DispatchTypeEntry>.TableName => TableName;

    static DispatchTypeEntry IEntry<DispatchTypeEntry>.CreateInstance(BinaryReader reader)
    {
        return new DispatchTypeEntry(reader);
    }
}
