global using WinPoseKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class WinPoseEntry : IEntry<WinPoseEntry>
{
    public const string TableName = "tb_Win_Pose";

    public WinPoseKeyType Id { get; set; }
    public uint Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public string Field4 { get; set; } = string.Empty;
    public string Field5 { get; set; } = string.Empty;
    public byte Field6 { get; set; }

    public WinPoseEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt32();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUTF16UnicodeString();
        Field5 = reader.ReadUTF16UnicodeString();
        Field6 = reader.ReadByte();
    }

    static string IEntry<WinPoseEntry>.TableName => TableName;

    static WinPoseEntry IEntry<WinPoseEntry>.CreateInstance(BinaryReader reader)
    {
        return new WinPoseEntry(reader);
    }
}
