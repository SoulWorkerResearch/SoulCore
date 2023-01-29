global using AkashicSlotExtendKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class AkashicSlotExtendEntry : IEntry<AkashicSlotExtendEntry>
{
    public const string TableName = "tb_Akashic_Slot_Extend";

    public AkashicSlotExtendKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }

    public AkashicSlotExtendEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
    }

    static string IEntry<AkashicSlotExtendEntry>.TableName => TableName;

    static AkashicSlotExtendEntry IEntry<AkashicSlotExtendEntry>.CreateInstance(BinaryReader reader)
    {
        return new AkashicSlotExtendEntry(reader);
    }
}
