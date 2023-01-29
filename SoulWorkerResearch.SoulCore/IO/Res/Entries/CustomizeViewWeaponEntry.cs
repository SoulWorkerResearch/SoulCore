global using CustomizeViewWeaponKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class CustomizeViewWeaponEntry : IEntry<CustomizeViewWeaponEntry>
{
    public const string TableName = "tb_Customize_View_Weapon";

    public CustomizeViewWeaponKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }

    public CustomizeViewWeaponEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
    }

    static string IEntry<CustomizeViewWeaponEntry>.TableName => TableName;

    static CustomizeViewWeaponEntry IEntry<CustomizeViewWeaponEntry>.CreateInstance(BinaryReader reader)
    {
        return new CustomizeViewWeaponEntry(reader);
    }
}
