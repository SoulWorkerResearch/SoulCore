using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VCheckEventSpawnBox : VEntity
    {
        /// <summary>
        /// Object Type
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// Generated event probability, ten thousand minutes rate(10000=100%)
        /// </summary>
        public float EventRate { get; set; }

        /// <summary>
        /// Until the event occurs after the delay time
        /// </summary>
        public float EventDelayTime { get; set; }

        /// <summary>
        /// Operation of the event file
        /// </summary>
        public uint EventOperation { get; set; }

        /// <summary>
        /// The event timeout, ms(1seconds = 1000ms)
        /// </summary>
        public float EventTime { get; set; }

        /// <summary>
        /// Spawn Box ID
        /// </summary>
        public List<uint> SpawnBoxes { get; set; } = new();

        public VCheckEventSpawnBox()
        {
        }

        public VCheckEventSpawnBox(XmlNode xml) : base(xml)
        {
            EventType = xml.GetEnum<EventType>("m_eEvent_Type");
            EventRate = xml.GetSingle("m_fEvent_Rate");
            EventDelayTime = xml.GetSingle("m_fEvent_Delay_Time");
            EventOperation = xml.GetUInt32("m_iEvent_Operation_ID");
            EventTime = xml.GetSingle("m_fEvent_Time");
            SpawnBoxes = Enumerable.Range(1, 6).Select(id => xml.GetUInt32($"m_iSpawn_Box_ID_{id}")).ToList();
        }
    }
}
