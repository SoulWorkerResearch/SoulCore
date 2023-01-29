global using PetGainInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetGainInfoEntry : IEntry<PetGainInfoEntry>
{
    public const string TableName = "tb_Pet_Gain_Info";

    public PetGainInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }

    public PetGainInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
    }

    static string IEntry<PetGainInfoEntry>.TableName => TableName;

    static PetGainInfoEntry IEntry<PetGainInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetGainInfoEntry(reader);
    }
}
