global using ShopStringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ShopStringEntry : IEntry<ShopStringEntry>
{
    public const string TableName = "tb_Shop_String";

    public ShopStringKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public ShopStringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<ShopStringEntry>.TableName => TableName;

    static ShopStringEntry IEntry<ShopStringEntry>.CreateInstance(BinaryReader reader)
    {
        return new ShopStringEntry(reader);
    }
}
