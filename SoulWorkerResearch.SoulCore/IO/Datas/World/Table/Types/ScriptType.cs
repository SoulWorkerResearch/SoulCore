using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types
{
    public enum ScriptType : byte
    {
        None,
        Spawn,

        [XmlEnum("HP")]
        Hp
    }
}
