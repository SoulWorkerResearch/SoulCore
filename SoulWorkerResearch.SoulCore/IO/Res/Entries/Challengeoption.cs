global using ChallengeoptionKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ChallengeoptionEntry : IEntry<ChallengeoptionEntry>
{
    public const string TableName = "tb_ChallengeOption";

    public ChallengeoptionKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }

    public ChallengeoptionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
    }

    static string IEntry<ChallengeoptionEntry>.TableName => TableName;

    static ChallengeoptionEntry IEntry<ChallengeoptionEntry>.CreateInstance(BinaryReader reader)
    {
        return new ChallengeoptionEntry(reader);
    }
}
