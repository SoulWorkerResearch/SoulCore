using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Types;

public enum MonsterSpawnType : byte
{
    Monster,
    DestructionObject,
    TreasureBox,
    Unit,
    SocialObject,

    [XmlEnum("NPC")] Npc
}
