global using PetExpKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetExpEntry : IEntry<PetExpEntry>
{
    public const string TableName = "tb_Pet_Exp";

    public PetExpKeyType Id { get; set; }
    public ushort Field1 { get; set; }

    public PetExpEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUInt16();
    }

    static string IEntry<PetExpEntry>.TableName => TableName;

    static PetExpEntry IEntry<PetExpEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetExpEntry(reader);
    }
}
