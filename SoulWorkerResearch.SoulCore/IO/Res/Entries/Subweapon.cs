global using SubweaponKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SubweaponEntry : IEntry<SubweaponEntry>
{
    public const string TableName = "tb_SubWeapon";

    public SubweaponKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public uint Field2 { get; set; }

    public SubweaponEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadUInt32();
    }

    static string IEntry<SubweaponEntry>.TableName => TableName;

    static SubweaponEntry IEntry<SubweaponEntry>.CreateInstance(BinaryReader reader)
    {
        return new SubweaponEntry(reader);
    }
}
