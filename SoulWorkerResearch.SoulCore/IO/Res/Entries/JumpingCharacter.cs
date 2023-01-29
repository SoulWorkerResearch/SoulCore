global using JumpingCharacterKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class JumpingCharacterEntry : IEntry<JumpingCharacterEntry>
{
    public const string TableName = "tb_Jumping_Character";

    public JumpingCharacterKeyType Id { get; set; }
    public ushort Field1 { get; set; }
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }
    public short Field4 { get; set; }

    public JumpingCharacterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUInt16();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
        Field4 = reader.ReadInt16();
    }

    static string IEntry<JumpingCharacterEntry>.TableName => TableName;

    static JumpingCharacterEntry IEntry<JumpingCharacterEntry>.CreateInstance(BinaryReader reader)
    {
        return new JumpingCharacterEntry(reader);
    }
}
