global using PetVoiceKeyType = System.UInt16;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetVoiceEntry : IEntry<PetVoiceEntry>
{
    public const string TableName = "tb_Pet_Voice";

    public PetVoiceKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public byte Field4 { get; set; }
    public byte Field5 { get; set; }
    public byte Field6 { get; set; }
    public byte Field7 { get; set; }
    public byte Field8 { get; set; }
    public byte Field9 { get; set; }
    public byte Field10 { get; set; }
    public byte Field11 { get; set; }
    public byte Field12 { get; set; }
    public byte Field13 { get; set; }
    public byte Field14 { get; set; }
    public byte Field15 { get; set; }
    public byte Field16 { get; set; }
    public byte Field17 { get; set; }
    public uint Field18 { get; set; }
    public uint Field19 { get; set; }
    public uint Field20 { get; set; }
    public uint Field21 { get; set; }
    public uint Field22 { get; set; }
    public uint Field23 { get; set; }
    public uint Field24 { get; set; }
    public uint Field25 { get; set; }
    public uint Field26 { get; set; }
    public uint Field27 { get; set; }
    public uint Field28 { get; set; }
    public uint Field29 { get; set; }
    public uint Field30 { get; set; }
    public uint Field31 { get; set; }
    public uint Field32 { get; set; }
    public uint Field33 { get; set; }

    public PetVoiceEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadByte();
        Field5 = reader.ReadByte();
        Field6 = reader.ReadByte();
        Field7 = reader.ReadByte();
        Field8 = reader.ReadByte();
        Field9 = reader.ReadByte();
        Field10 = reader.ReadByte();
        Field11 = reader.ReadByte();
        Field12 = reader.ReadByte();
        Field13 = reader.ReadByte();
        Field14 = reader.ReadByte();
        Field15 = reader.ReadByte();
        Field16 = reader.ReadByte();
        Field17 = reader.ReadByte();
        Field18 = reader.ReadUInt32();
        Field19 = reader.ReadUInt32();
        Field20 = reader.ReadUInt32();
        Field21 = reader.ReadUInt32();
        Field22 = reader.ReadUInt32();
        Field23 = reader.ReadUInt32();
        Field24 = reader.ReadUInt32();
        Field25 = reader.ReadUInt32();
        Field26 = reader.ReadUInt32();
        Field27 = reader.ReadUInt32();
        Field28 = reader.ReadUInt32();
        Field29 = reader.ReadUInt32();
        Field30 = reader.ReadUInt32();
        Field31 = reader.ReadUInt32();
        Field32 = reader.ReadUInt32();
        Field33 = reader.ReadUInt32();
    }

    static string IEntry<PetVoiceEntry>.TableName => TableName;

    static PetVoiceEntry IEntry<PetVoiceEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetVoiceEntry(reader);
    }
}
