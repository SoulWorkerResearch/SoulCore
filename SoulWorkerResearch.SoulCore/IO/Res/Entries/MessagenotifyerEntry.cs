global using MessagenotifyerKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MessagenotifyerEntry : IEntry<MessagenotifyerEntry>
{
    public const string TableName = "tb_MessageNotifyer";

    public MessagenotifyerKeyType Id { get; set; }
    public sbyte Field1 { get; set; }
    public sbyte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }

    public MessagenotifyerEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadSByte();
        Field2 = reader.ReadSByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<MessagenotifyerEntry>.TableName => TableName;

    static MessagenotifyerEntry IEntry<MessagenotifyerEntry>.CreateInstance(BinaryReader reader)
    {
        return new MessagenotifyerEntry(reader);
    }
}
