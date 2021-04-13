using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types
{
    public enum MonsterSpawnType : byte
    {
        Monster,
        DestructionObject,
        TreasureBox,
        Unit,

        [XmlEnum("NPC")]
        Npc
    }
}
