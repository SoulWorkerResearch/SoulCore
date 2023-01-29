global using VoiceringKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class VoiceringEntry : IEntry<VoiceringEntry>
{
    public const string TableName = "tb_VoiceRing";

    public VoiceringKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public string Field5 { get; set; } = string.Empty;

    public VoiceringEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<VoiceringEntry>.TableName => TableName;

    static VoiceringEntry IEntry<VoiceringEntry>.CreateInstance(BinaryReader reader)
    {
        return new VoiceringEntry(reader);
    }
}
