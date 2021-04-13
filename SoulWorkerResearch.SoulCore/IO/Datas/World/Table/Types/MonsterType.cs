using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types
{
    public enum MonsterType : byte
    {
        Npc,
        Monster,
        DestructionObject,

        [XmlEnum("PC")]
        Pc,
    }
}
