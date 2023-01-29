global using GestureSlotExtendKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class GestureSlotExtendEntry : IEntry<GestureSlotExtendEntry>
{
    public const string TableName = "tb_Gesture_Slot_Extend";

    public GestureSlotExtendKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public ushort Field5 { get; set; }

    public GestureSlotExtendEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt16();
    }

    static string IEntry<GestureSlotExtendEntry>.TableName => TableName;

    static GestureSlotExtendEntry IEntry<GestureSlotExtendEntry>.CreateInstance(BinaryReader reader)
    {
        return new GestureSlotExtendEntry(reader);
    }
}
