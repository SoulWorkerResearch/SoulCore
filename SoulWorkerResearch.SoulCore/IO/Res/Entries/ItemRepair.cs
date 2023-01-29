global using ItemRepairKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class ItemRepairEntry : IEntry<ItemRepairEntry>
{
    public const string TableName = "tb_Item_Repair";

    public ItemRepairKeyType Id { get; set; }
    public float Field1 { get; set; }
    public float Field2 { get; set; }
    public float Field3 { get; set; }
    public float Field4 { get; set; }
    public float Field5 { get; set; }
    public float Field6 { get; set; }
    public float Field7 { get; set; }
    public float Field8 { get; set; }
    public float Field9 { get; set; }
    public float Field10 { get; set; }
    public float Field11 { get; set; }
    public float Field12 { get; set; }
    public float Field13 { get; set; }
    public float Field14 { get; set; }
    public float Field15 { get; set; }
    public float Field16 { get; set; }
    public float Field17 { get; set; }
    public float Field18 { get; set; }
    public float Field19 { get; set; }
    public float Field20 { get; set; }
    public float Field21 { get; set; }
    public float Field22 { get; set; }
    public float Field23 { get; set; }
    public float Field24 { get; set; }
    public float Field25 { get; set; }

    public ItemRepairEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadSingle();
        Field2 = reader.ReadSingle();
        Field3 = reader.ReadSingle();
        Field4 = reader.ReadSingle();
        Field5 = reader.ReadSingle();
        Field6 = reader.ReadSingle();
        Field7 = reader.ReadSingle();
        Field8 = reader.ReadSingle();
        Field9 = reader.ReadSingle();
        Field10 = reader.ReadSingle();
        Field11 = reader.ReadSingle();
        Field12 = reader.ReadSingle();
        Field13 = reader.ReadSingle();
        Field14 = reader.ReadSingle();
        Field15 = reader.ReadSingle();
        Field16 = reader.ReadSingle();
        Field17 = reader.ReadSingle();
        Field18 = reader.ReadSingle();
        Field19 = reader.ReadSingle();
        Field20 = reader.ReadSingle();
        Field21 = reader.ReadSingle();
        Field22 = reader.ReadSingle();
        Field23 = reader.ReadSingle();
        Field24 = reader.ReadSingle();
        Field25 = reader.ReadSingle();
    }

    static string IEntry<ItemRepairEntry>.TableName => TableName;

    static ItemRepairEntry IEntry<ItemRepairEntry>.CreateInstance(BinaryReader reader)
    {
        return new ItemRepairEntry(reader);
    }
}
