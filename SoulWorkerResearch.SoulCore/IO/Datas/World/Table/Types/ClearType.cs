using System.Xml.Serialization;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types
{
    public enum ClearType : byte
    {
        None,
        Kill,
        Always,
        ModeClear,

        [XmlEnum("KillPerpect")]
        Kill_Perpect,
    }
}
