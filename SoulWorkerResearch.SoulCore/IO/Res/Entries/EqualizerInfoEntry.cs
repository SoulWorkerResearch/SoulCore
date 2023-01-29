global using EqualizerInfoKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class EqualizerInfoEntry : IEntry<EqualizerInfoEntry>
{
    public const string TableName = "tb_Equalizer_Info";

    public EqualizerInfoKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public uint Field2 { get; set; }
    public uint Field3 { get; set; }
    public byte Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;

    public EqualizerInfoEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadUInt32();
        Field3 = reader.ReadUInt32();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<EqualizerInfoEntry>.TableName => TableName;

    static EqualizerInfoEntry IEntry<EqualizerInfoEntry>.CreateInstance(BinaryReader reader)
    {
        return new EqualizerInfoEntry(reader);
    }
}
