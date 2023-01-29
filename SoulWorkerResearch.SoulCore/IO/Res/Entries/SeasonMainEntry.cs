global using SeasonMainKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SeasonMainEntry : IEntry<SeasonMainEntry>
{
    public const string TableName = "tb_Season_Main";

    public SeasonMainKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public byte Field2 { get; set; }
    public uint Field3 { get; set; }
    public ushort Field4 { get; set; }

    public SeasonMainEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadUInt16();
    }

    static string IEntry<SeasonMainEntry>.TableName => TableName;

    static SeasonMainEntry IEntry<SeasonMainEntry>.CreateInstance(BinaryReader reader)
    {
        return new SeasonMainEntry(reader);
    }
}
