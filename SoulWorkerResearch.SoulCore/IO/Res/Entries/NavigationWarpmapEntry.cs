global using NavigationWarpmapKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class NavigationWarpmapEntry : IEntry<NavigationWarpmapEntry>
{
    public const string TableName = "tb_Navigation_Warpmap";

    public NavigationWarpmapKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }
    public ushort Field4 { get; set; }
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }
    public ushort Field7 { get; set; }
    public ushort Field8 { get; set; }
    public uint Field9 { get; set; }
    public ushort Field10 { get; set; }

    public NavigationWarpmapEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
        Field4 = reader.ReadUInt16();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt16();
        Field8 = reader.ReadUInt16();
        Field9 = reader.ReadUInt32();
        Field10 = reader.ReadUInt16();
    }

    static string IEntry<NavigationWarpmapEntry>.TableName => TableName;

    static NavigationWarpmapEntry IEntry<NavigationWarpmapEntry>.CreateInstance(BinaryReader reader)
    {
        return new NavigationWarpmapEntry(reader);
    }
}
