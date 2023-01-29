global using DisassembleKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class DisassembleEntry : IEntry<DisassembleEntry>
{
    public const string TableName = "tb_Disassemble";

    public DisassembleKeyType Id { get; set; }

    public DisassembleEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
    }

    static string IEntry<DisassembleEntry>.TableName => TableName;

    static DisassembleEntry IEntry<DisassembleEntry>.CreateInstance(BinaryReader reader)
    {
        return new DisassembleEntry(reader);
    }
}
