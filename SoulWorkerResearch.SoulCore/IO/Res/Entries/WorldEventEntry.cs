global using WorldEventKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class WorldEventEntry : IEntry<WorldEventEntry>
{
    public const string TableName = "tb_world_event";

    public WorldEventKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public string Field2 { get; set; } = string.Empty;
    public string Field3 { get; set; } = string.Empty;
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public uint Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public ushort Field9 { get; set; }
    public uint Field10 { get; set; }

    public WorldEventEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadUTF16UnicodeString();
        Field3 = reader.ReadUTF16UnicodeString();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt32();
    }

    static string IEntry<WorldEventEntry>.TableName => TableName;

    static WorldEventEntry IEntry<WorldEventEntry>.CreateInstance(BinaryReader reader)
    {
        return new WorldEventEntry(reader);
    }
}
