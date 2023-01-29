global using ModeCardmatchFactionKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ModeCardmatchFactionEntry : IEntry<ModeCardmatchFactionEntry>
{
    public const string TableName = "tb_Mode_CardMatch_Faction";

    public ModeCardmatchFactionKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public ushort Field9 { get; set; }

    public ModeCardmatchFactionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt16();
    }

    static string IEntry<ModeCardmatchFactionEntry>.TableName => TableName;

    static ModeCardmatchFactionEntry IEntry<ModeCardmatchFactionEntry>.CreateInstance(BinaryReader reader)
    {
        return new ModeCardmatchFactionEntry(reader);
    }
}
