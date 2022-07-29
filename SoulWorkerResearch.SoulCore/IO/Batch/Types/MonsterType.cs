using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Types;

public enum MonsterType : byte
{
    Npc,
    Monster,
    DestructionObject,

    [XmlEnum("PC")]
    Pc,
}
