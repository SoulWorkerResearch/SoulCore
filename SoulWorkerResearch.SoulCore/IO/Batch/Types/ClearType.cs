using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Types;

public enum ClearType : byte
{
    None,
    Kill,
    Always,
    ModeClear,

    [XmlEnum("Kill_Perpect")]
    KillPerpect,
}
