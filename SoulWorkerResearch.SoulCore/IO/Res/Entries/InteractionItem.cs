global using InteractionItemKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class InteractionItemEntry : IEntry<InteractionItemEntry>
{
    public const string TableName = "tb_Interaction_Item";

    public InteractionItemKeyType Id { get; set; }

    public InteractionItemEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
    }

    static string IEntry<InteractionItemEntry>.TableName => TableName;

    static InteractionItemEntry IEntry<InteractionItemEntry>.CreateInstance(BinaryReader reader)
    {
        return new InteractionItemEntry(reader);
    }
}
