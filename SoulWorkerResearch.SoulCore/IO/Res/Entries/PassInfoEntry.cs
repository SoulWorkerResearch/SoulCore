global using PassInfoKeyType = System.UInt32;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record PassInfoEntry : ITableEntry<PassInfoKeyType>
{
    public const string TableName = "tb_Pass_Info";

    public PassInfoKeyType Id { get; }
    public uint v6 { get; }
    public byte v7 { get; }
    public uint v8 { get; }
    public string StartDate { get; }
    public string EndDate { get; }
    public byte v11 { get; }
    public string Cover { get; }
    public string ItemIcon { get; }
    public uint v14 { get; }

    public PassInfoEntry(BinaryReader br)
    {
        Id = br.ReadUInt32();
        v6 = br.ReadUInt32();
        v7 = br.ReadByte();
        v8 = br.ReadUInt32();
        StartDate = br.ReadUTF16UnicodeString();
        EndDate = br.ReadUTF16UnicodeString();
        v11 = br.ReadByte();
        Cover = br.ReadUTF16UnicodeString();
        ItemIcon = br.ReadUTF16UnicodeString();
        v14 = br.ReadUInt32();
    }
}
