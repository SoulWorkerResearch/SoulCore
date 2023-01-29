global using PvpLevelupPointKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PvpLevelupPointEntry : IEntry<PvpLevelupPointEntry>
{
    public const string TableName = "tb_PvP_levelup_Point";

    public PvpLevelupPointKeyType Id { get; set; }
    public int Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }

    public PvpLevelupPointEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
    }

    static string IEntry<PvpLevelupPointEntry>.TableName => TableName;

    static PvpLevelupPointEntry IEntry<PvpLevelupPointEntry>.CreateInstance(BinaryReader reader)
    {
        return new PvpLevelupPointEntry(reader);
    }
}
