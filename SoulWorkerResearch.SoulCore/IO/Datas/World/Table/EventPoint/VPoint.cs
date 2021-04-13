using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventPoint
{
    public abstract record VPoint : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public PointType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        public BattleType BattleType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint BeforePoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        public List<uint> NextPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string IdleAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint IdleActionRatio { get; set; }

        /// <summary>
        ///
        /// </summary>
        public uint DelayTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        public byte RepeatCount { get; set; }

        protected VPoint(XmlNode xml) : base(xml)
        {
            Type = xml.GetEnum<PointType>("m_eType");
            BattleType = xml.GetEnum<BattleType>("m_eBattleType");
            BeforePoint = xml.GetUInt32("m_iBeforePoint");
            NextPoints = Enumerable.Range(1, 4).Select(id => xml.GetUInt32($"m_iNextPoint{(id > 1 ? id : "")}")).ToList();
            IdleAction = xml.GetString("m_szIdleAction");
            IdleActionRatio = xml.GetUInt32("m_uiIdleActionRatio");
            DelayTime = xml.GetUInt32("m_uiDelayTime");
            RepeatCount = xml.GetByte("m_RepeatCount");
        }
    }
}
