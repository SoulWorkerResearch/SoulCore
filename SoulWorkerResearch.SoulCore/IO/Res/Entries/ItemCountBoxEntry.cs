global using ItemCountBoxKeyType = System.UInt32;
using SoulWorkerResearch.SoulCore.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record ItemCountBoxEntry : ITableEntry<ItemCountBoxKeyType>
{
    public const string TableName = "tb_Item_CountBox";

    public const byte UsageGroupCount = 30;

    public ItemCountBoxKeyType Id { get; }
    public byte UsageCount { get; }
    public IReadOnlyList<ushort> UsageGroup { get; }

    public ItemCountBoxEntry(BinaryReader br)
    {
        Id = br.ReadUInt16();
        UsageCount = br.ReadByte();
        UsageGroup = br.ReadUInt16AsArray(UsageGroupCount);
    }
}
