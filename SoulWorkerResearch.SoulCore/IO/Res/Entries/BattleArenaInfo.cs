global using BattleArenaInfoKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BattleArenaInfoEntry : IEntry<BattleArenaInfoEntry>
{
    public const string TableName = "tb_Battle_Arena_Info";

    public BattleArenaInfoKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }

    public BattleArenaInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
    }

    static string IEntry<BattleArenaInfoEntry>.TableName => TableName;

    static BattleArenaInfoEntry IEntry<BattleArenaInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new BattleArenaInfoEntry(reader);
    }
}
