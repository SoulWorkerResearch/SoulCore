using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Types;

public enum ScriptType : byte
{
    None,
    Spawn,

    [XmlEnum("HP")]
    Hp
}
