global using ApplychallengeKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ApplychallengeEntry : IEntry<ApplychallengeEntry>
{
    public const string TableName = "tb_ApplyChallenge";

    public ApplychallengeKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public ushort Field5 { get; set; }
    public ushort Field6 { get; set; }
    public uint Field7 { get; set; }

    public ApplychallengeEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt16();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt32();
    }

    static string IEntry<ApplychallengeEntry>.TableName => TableName;

    static ApplychallengeEntry IEntry<ApplychallengeEntry>.CreateInstance(BinaryReader reader)
    {
        return new ApplychallengeEntry(reader);
    }
}
