global using DefensiveWeaponKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DefensiveWeaponEntry : IEntry<DefensiveWeaponEntry>
{
    public const string TableName = "tb_Defensive_Weapon";

    public DefensiveWeaponKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public short Field2 { get; set; }
    public short Field3 { get; set; }
    public short Field4 { get; set; }
    public short Field5 { get; set; }
    public short Field6 { get; set; }
    public byte Field7 { get; set; }
    public string Field8 { get; set; } = string.Empty;

    public DefensiveWeaponEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadInt16();
        Field3 = reader.ReadInt16();
        Field4 = reader.ReadInt16();
        Field5 = reader.ReadInt16();
        Field6 = reader.ReadInt16();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<DefensiveWeaponEntry>.TableName => TableName;

    static DefensiveWeaponEntry IEntry<DefensiveWeaponEntry>.CreateInstance(BinaryReader reader)
    {
        return new DefensiveWeaponEntry(reader);
    }
}
