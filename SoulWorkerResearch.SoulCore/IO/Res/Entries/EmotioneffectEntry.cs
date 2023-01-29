global using EmotioneffectKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class EmotioneffectEntry : IEntry<EmotioneffectEntry>
{
    public const string TableName = "tb_EmotionEffect";

    public EmotioneffectKeyType Id { get; set; }
    public short Field1 { get; set; }
    public short Field2 { get; set; }
    public byte Field3 { get; set; }
    public short Field4 { get; set; }
    public ushort Field5 { get; set; }

    public EmotioneffectEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadInt16();
        Field2 = reader.ReadInt16();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadInt16();
        Field5 = reader.ReadUInt16();
    }

    static string IEntry<EmotioneffectEntry>.TableName => TableName;

    static EmotioneffectEntry IEntry<EmotioneffectEntry>.CreateInstance(BinaryReader reader)
    {
        return new EmotioneffectEntry(reader);
    }
}
