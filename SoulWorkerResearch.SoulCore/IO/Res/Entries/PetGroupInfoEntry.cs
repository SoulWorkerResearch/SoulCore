global using PetGroupInfoKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetGroupInfoEntry : IEntry<PetGroupInfoEntry>
{
    public const string TableName = "tb_Pet_Group_Info";

    public PetGroupInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public ushort Field2 { get; set; }
    public ushort Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }

    public PetGroupInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt16();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
    }

    static string IEntry<PetGroupInfoEntry>.TableName => TableName;

    static PetGroupInfoEntry IEntry<PetGroupInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetGroupInfoEntry(reader);
    }
}
