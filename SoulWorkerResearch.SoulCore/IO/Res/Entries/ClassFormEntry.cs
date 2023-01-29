global using ClassFormKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ClassFormEntry : IEntry<ClassFormEntry>
{
    public const string TableName = "tb_Class_form";

    public ClassFormKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public ClassFormEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ClassFormEntry>.TableName => TableName;

    static ClassFormEntry IEntry<ClassFormEntry>.CreateInstance(BinaryReader reader)
    {
        return new ClassFormEntry(reader);
    }
}
