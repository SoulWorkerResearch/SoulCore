global using MyroomInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class MyroomInfoEntry : IEntry<MyroomInfoEntry>
{
    public const string TableName = "tb_Myroom_Info";

    public MyroomInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }

    public MyroomInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
    }

    static string IEntry<MyroomInfoEntry>.TableName => TableName;

    static MyroomInfoEntry IEntry<MyroomInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new MyroomInfoEntry(reader);
    }
}
