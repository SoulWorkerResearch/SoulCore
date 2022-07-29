using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Types;

public enum EntityType : byte
{
    [XmlEnum("PC")]
    Pc,

    Npc,
    Monster,
    None
}
