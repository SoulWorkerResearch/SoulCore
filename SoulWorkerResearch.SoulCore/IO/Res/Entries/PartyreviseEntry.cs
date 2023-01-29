global using PartyreviseKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PartyreviseEntry : IEntry<PartyreviseEntry>
{
    public const string TableName = "tb_PartyRevise";

    public PartyreviseKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }

    public PartyreviseEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
    }

    static string IEntry<PartyreviseEntry>.TableName => TableName;

    static PartyreviseEntry IEntry<PartyreviseEntry>.CreateInstance(BinaryReader reader)
    {
        return new PartyreviseEntry(reader);
    }
}
