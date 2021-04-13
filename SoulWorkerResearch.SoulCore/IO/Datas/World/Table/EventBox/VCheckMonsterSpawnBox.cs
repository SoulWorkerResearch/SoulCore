using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VCheckMonsterSpawnBox : VEntity
    {
        /// <summary>
        /// CheckType
        /// </summary>
        public MonsterType Type { get; set; }

        /// <summary>
        /// LoopCount
        /// </summary>
        public uint LoopCount { get; set; }

        /// <summary>
        /// Target ID to work with this box to collide (as CheckType and find the target in combination)
        /// </summary>
        public uint Entity { get; set; }

        /// <summary>
        ///
        /// </summary>
        public List<uint> CheckBoxes { get; set; }

        internal VCheckMonsterSpawnBox(XmlNode xml) : base(xml)
        {
            Type = xml.GetEnum<MonsterType>("m_eType");
            LoopCount = xml.GetUInt32("m_iLoopCount");
            Entity = xml.GetUInt32("m_iEntityID");
            CheckBoxes = Enumerable.Range(0, 10).Select(id => xml.GetUInt32($"m_iCheckBox_{id}")).ToList();
        }
    }
}
