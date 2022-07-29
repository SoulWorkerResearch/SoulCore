global using ItemScriptKeyType = System.UInt32;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record ItemScriptEntry : ITableEntry<ItemScriptKeyType>
{
    public const string TableName = "tb_item_script";

    public ItemScriptKeyType Id { get; }
    public string Icon { get; }
    public string Unknown6 { get; }
    public string Unknown7 { get; }
    public string Unknown8 { get; }
    public string Unknown9 { get; }
    public string Unknown10 { get; }
    public byte Unknown11 { get; }
    public byte Unknown12 { get; }
    public byte Unknown13 { get; }
    public byte Unknown14 { get; }
    public byte Unknown15 { get; }
    public string Name { get; }
    public string Description { get; }

    public ItemScriptEntry(BinaryReader br)
    {
        Id = br.ReadUInt32();
        Icon = br.ReadUTF16UnicodeString();
        Unknown6 = br.ReadUTF16UnicodeString();
        Unknown7 = br.ReadUTF16UnicodeString();
        Unknown8 = br.ReadUTF16UnicodeString();
        Unknown9 = br.ReadUTF16UnicodeString();
        Unknown10 = br.ReadUTF16UnicodeString();
        Unknown11 = br.ReadByte();
        Unknown12 = br.ReadByte();
        Unknown13 = br.ReadByte();
        Unknown14 = br.ReadByte();
        Unknown15 = br.ReadByte();
        Name = br.ReadUTF16UnicodeString();
        Description = br.ReadUTF16UnicodeString();
    }
}
