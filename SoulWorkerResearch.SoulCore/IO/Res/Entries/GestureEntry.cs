global using GestureKeyType = System.UInt16;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record GestureEntry : ITableEntry<GestureKeyType>
{
    public const string TableName = "tb_Gesture";

    public GestureKeyType Id { get; }
    public CustomizeEyesKeyType Class { get; }
    public byte MinLevel { get; }
    public byte InitialGesture { get; }
    public uint CoolTime { get; }
    public ushort Unknown5 { get; }
    public uint Unknown6 { get; }
    public string Unknown7 { get; }
    public byte Unknown8 { get; }
    public uint Unknown9 { get; }
    public uint Unknown10 { get; }
    public uint Unknown11 { get; }
    public uint Unknown12 { get; }
    public string Unknown13 { get; }
    public string Unknown14 { get; }
    public string Unknown15 { get; }
    public uint Unknown16 { get; }
    public ushort Unknown17 { get; }
    public ushort Unknown18 { get; }

    public GestureEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Class = reader.ReadClass();
        MinLevel = reader.ReadByte();
        InitialGesture = reader.ReadByte();
        CoolTime = reader.ReadUInt32();
        Unknown5 = reader.ReadUInt16();
        Unknown6 = reader.ReadUInt32();
        Unknown7 = reader.ReadUTF16UnicodeString();
        Unknown8 = reader.ReadByte();
        Unknown9 = reader.ReadUInt32();
        Unknown10 = reader.ReadUInt32();
        Unknown11 = reader.ReadUInt32();
        Unknown12 = reader.ReadUInt32();
        Unknown13 = reader.ReadUTF16UnicodeString();
        Unknown14 = reader.ReadUTF16UnicodeString();
        Unknown15 = reader.ReadUTF16UnicodeString();
        Unknown16 = reader.ReadUInt32();
        Unknown17 = reader.ReadUInt16();
        Unknown18 = reader.ReadUInt16();
    }
}
