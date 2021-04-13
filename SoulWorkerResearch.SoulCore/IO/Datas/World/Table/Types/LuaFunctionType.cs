using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types
{
    public enum LuaFunctionType : byte
    {
        Self,
        Party,
        Monster,
        Warp,

        [XmlEnum("NPC")]
        Npc
    }
}
