global using WarlordGuiKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class WarlordGuiEntry : IEntry<WarlordGuiEntry>
{
    public const string TableName = "tb_Warlord_GUI";

    public WarlordGuiKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }

    public WarlordGuiEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
    }

    static string IEntry<WarlordGuiEntry>.TableName => TableName;

    static WarlordGuiEntry IEntry<WarlordGuiEntry>.CreateInstance(BinaryReader reader)
    {
        return new WarlordGuiEntry(reader);
    }
}
