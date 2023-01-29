global using ChangeMobIdKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ChangeMobIdEntry : IEntry<ChangeMobIdEntry>
{
    public const string TableName = "tb_Change_Mob_ID";

    public ChangeMobIdKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }

    public ChangeMobIdEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
    }

    static string IEntry<ChangeMobIdEntry>.TableName => TableName;

    static ChangeMobIdEntry IEntry<ChangeMobIdEntry>.CreateInstance(BinaryReader reader)
    {
        return new ChangeMobIdEntry(reader);
    }
}
