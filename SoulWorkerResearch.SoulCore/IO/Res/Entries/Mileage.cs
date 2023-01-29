global using MileageKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MileageEntry : IEntry<MileageEntry>
{
    public const string TableName = "tb_Mileage";

    public MileageKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }

    public MileageEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
    }

    static string IEntry<MileageEntry>.TableName => TableName;

    static MileageEntry IEntry<MileageEntry>.CreateInstance(BinaryReader reader)
    {
        return new MileageEntry(reader);
    }
}
