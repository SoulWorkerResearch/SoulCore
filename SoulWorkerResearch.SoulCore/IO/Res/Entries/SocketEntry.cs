global using SocketKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class SocketEntry : IEntry<SocketEntry>
{
    public const string TableName = "tb_Socket";

    public SocketKeyType Id { get; set; }
    public byte Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public uint Field4 { get; set; }
    public uint Field5 { get; set; }
    public ushort Field6 { get; set; }
    public uint Field7 { get; set; }
    public uint Field8 { get; set; }
    public ushort Field9 { get; set; }
    public uint Field10 { get; set; }
    public uint Field11 { get; set; }
    public ushort Field12 { get; set; }
    public uint Field13 { get; set; }
    public ushort Field14 { get; set; }

    public SocketEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadByte();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadUInt32();
        Field5 = reader.ReadUInt32();
        Field6 = reader.ReadUInt16();
        Field7 = reader.ReadUInt32();
        Field8 = reader.ReadUInt32();
        Field9 = reader.ReadUInt16();
        Field10 = reader.ReadUInt32();
        Field11 = reader.ReadUInt32();
        Field12 = reader.ReadUInt16();
        Field13 = reader.ReadUInt32();
        Field14 = reader.ReadUInt16();
    }

    static string IEntry<SocketEntry>.TableName => TableName;

    static SocketEntry IEntry<SocketEntry>.CreateInstance(BinaryReader reader)
    {
        return new SocketEntry(reader);
    }
}
