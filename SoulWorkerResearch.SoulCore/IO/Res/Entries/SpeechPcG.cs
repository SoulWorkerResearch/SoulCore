global using SpeechPcGKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SpeechPcGEntry : IEntry<SpeechPcGEntry>
{
    public const string TableName = "tb_Speech_PC_G";

    public SpeechPcGKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public uint Field6 { get; set; }
    public byte Field7 { get; set; }
    public string Field8 { get; set; } = string.Empty;
    public ushort Field9 { get; set; }
    public byte Field10 { get; set; }
    public ushort Field11 { get; set; }
    public string Field12 { get; set; } = string.Empty;
    public string Field13 { get; set; } = string.Empty;
    public string Field14 { get; set; } = string.Empty;

    public SpeechPcGEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadUInt32();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadUTF16UnicodeString();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadUInt16();
        Field12 = reader.ReadUTF16UnicodeString();
        Field13 = reader.ReadUTF16UnicodeString();
        Field14 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<SpeechPcGEntry>.TableName => TableName;

    static SpeechPcGEntry IEntry<SpeechPcGEntry>.CreateInstance(BinaryReader reader)
    {
        return new SpeechPcGEntry(reader);
    }
}
