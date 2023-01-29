global using SocialMotionKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SocialMotionEntry : IEntry<SocialMotionEntry>
{
    public const string TableName = "tb_Social_Motion";

    public SocialMotionKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public ushort Field3 { get; set; }

    public SocialMotionEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadUInt16();
    }

    static string IEntry<SocialMotionEntry>.TableName => TableName;

    static SocialMotionEntry IEntry<SocialMotionEntry>.CreateInstance(BinaryReader reader)
    {
        return new SocialMotionEntry(reader);
    }
}
