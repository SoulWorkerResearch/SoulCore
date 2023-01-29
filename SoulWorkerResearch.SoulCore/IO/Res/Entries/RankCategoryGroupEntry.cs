global using RankCategoryGroupKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class RankCategoryGroupEntry : IEntry<RankCategoryGroupEntry>
{
    public const string TableName = "tb_Rank_Category_Group";

    public RankCategoryGroupKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }

    public RankCategoryGroupEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
    }

    static string IEntry<RankCategoryGroupEntry>.TableName => TableName;

    static RankCategoryGroupEntry IEntry<RankCategoryGroupEntry>.CreateInstance(BinaryReader reader)
    {
        return new RankCategoryGroupEntry(reader);
    }
}
