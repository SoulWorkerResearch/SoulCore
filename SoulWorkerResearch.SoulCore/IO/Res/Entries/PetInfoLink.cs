global using PetInfoLinkKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class PetInfoLinkEntry : IEntry<PetInfoLinkEntry>
{
    public const string TableName = "tb_Pet_Info_Link";

    public PetInfoLinkKeyType Id { get; set; }
    public string Field1 { get; set; } = string.Empty;

    public PetInfoLinkEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        Field1 = reader.ReadUTF16UnicodeString();
    }

    static string IEntry<PetInfoLinkEntry>.TableName => TableName;

    static PetInfoLinkEntry IEntry<PetInfoLinkEntry>.CreateInstance(BinaryReader reader)
    {
        return new PetInfoLinkEntry(reader);
    }
}
