global using LevelupPointKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class LevelupPointEntry : IEntry<LevelupPointEntry>
{
    public const string TableName = "tb_Levelup_Point";

    public LevelupPointKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }

    public LevelupPointEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
    }

    static string IEntry<LevelupPointEntry>.TableName => TableName;

    static LevelupPointEntry IEntry<LevelupPointEntry>.CreateInstance(BinaryReader reader)
    {
        return new LevelupPointEntry(reader);
    }
}
