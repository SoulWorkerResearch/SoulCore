global using EventConditionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class EventConditionEntry : IEntry<EventConditionEntry>
{
    public const string TableName = "tb_Event_Condition";

    public EventConditionKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }

    public EventConditionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<EventConditionEntry>.TableName => TableName;

    static EventConditionEntry IEntry<EventConditionEntry>.CreateInstance(BinaryReader reader)
    {
        return new EventConditionEntry(reader);
    }
}
