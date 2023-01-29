global using TimeKeyType = System.Int32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class TimeEntry : IEntry<TimeEntry>
{
    public const string TableName = "tb_Time";

    public TimeKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public float Field2 { get; set; }

    public TimeEntry(BinaryReader reader)
    {
        Id = reader.ReadInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadSingle();
    }

    static string IEntry<TimeEntry>.TableName => TableName;

    static TimeEntry IEntry<TimeEntry>.CreateInstance(BinaryReader reader)
    {
        return new TimeEntry(reader);
    }
}
