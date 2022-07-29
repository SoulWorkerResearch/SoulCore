using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Types;

public enum LuaFunctionType : byte
{
    Self,
    Party,
    Monster,
    Warp,

    [XmlEnum("NPC")]
    Npc
}
