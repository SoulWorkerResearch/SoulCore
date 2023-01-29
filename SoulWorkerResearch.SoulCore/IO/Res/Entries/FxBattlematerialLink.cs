global using FxBattlematerialLinkKeyType = System.Byte;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class FxBattlematerialLinkEntry : IEntry<FxBattlematerialLinkEntry>
{
    public const string TableName = "tb_FX_BattleMaterial_Link";

    public FxBattlematerialLinkKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;
    public byte Field2 { get; set; }
    public byte Field3 { get; set; }

    public FxBattlematerialLinkEntry(BinaryReader reader)
    {
        Id = reader.ReadByte();
        Field1 = reader.ReadUTF16UnicodeString();
        Field2 = reader.ReadByte();
        Field3 = reader.ReadByte();
    }

    static string IEntry<FxBattlematerialLinkEntry>.TableName => TableName;

    static FxBattlematerialLinkEntry IEntry<FxBattlematerialLinkEntry>.CreateInstance(BinaryReader reader)
    {
        return new FxBattlematerialLinkEntry(reader);
    }
}
