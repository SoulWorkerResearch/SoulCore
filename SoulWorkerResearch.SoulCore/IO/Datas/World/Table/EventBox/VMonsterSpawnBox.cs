using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Extensions;
using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VMonsterSpawnBox : VEntity
    {
        /// <summary>
        ///
        /// </summary>
        public List<VMonster> Monsters { get; set; } = new();

        /// <summary>
        /// Creation Position Type.
        /// </summary>
        public CreationPositionType CreationPositionType { get; set; }

        /// <summary>
        /// Move Type.
        /// </summary>
        public MoveType MoveType { get; set; }

        /// <summary>
        /// Condition of Creation.
        /// </summary>
        public CreationConditionType CreationCondition { get; set; }

        /// <summary>
        /// EffectFile.
        /// </summary>
        public string CreationEffectFile { get; set; } = string.Empty;

        /// <summary>
        /// If Condition of Creation is 'WaitSignal', Determine whether the signal being generated in a few seconds.
        /// </summary>
        public float WaitCreationDelayTime { get; set; }

        /// <summary>
        /// If Condition of Creation is 'WaitSignal', Determines whether every few seconds sequentially generated.
        /// </summary>
        public float WaitCreationSequenceTime { get; set; }

        /// <summary>
        /// If Condition of Creation is 'WaitSignal', Not waiting for the signal to determine the maximum of times.
        /// </summary>
        public byte WaitCreationMaxWave { get; set; }

        /// <summary>
        /// The maximum number of objects that can be created. If Condition of Creation is 'WaitSignal', And let not exceed more than the maximum number of objects when creating objects.
        /// </summary>
        public byte MaxEntityCount { get; set; }

        /// <summary>
        /// Whether the spins in order from 1 to 3 monsters that spawn at a time set when you create a sequence generated.
        /// </summary>
        public WaitCreationSequenceType WaitCreationSequenceType { get; set; }

        /// <summary>
        /// Waypoint ID.
        /// </summary>
        public uint Waypoint { get; set; }

        /// <summary>
        /// AggroGroupID.
        /// </summary>
        public ushort AggroGroup { get; set; }

        /// <summary>
        /// AggroDistance.
        /// </summary>
        public uint AggroDistance { get; set; }

        /// <summary>
        /// AggroMaxCount.
        /// </summary>
        public ushort AggroMaxCount { get; set; }

        /// <summary>
        /// Multiplying the value of Sight.
        /// </summary>
        public float LookRatio { get; set; }

        /// <summary>
        /// View the sight will be displayed?
        /// </summary>
        public bool ShowSight { get; set; }

        /// <summary>
        /// ObjectKey
        /// </summary>
        public string ObjectKey { get; set; } = string.Empty;

        /// <summary>
        /// Scene script call type.
        /// </summary>
        public ScriptType ScriptType { get; set; }

        /// <summary>
        /// if Scene script call type is HP, the event box being run. HP(100 = 100%).
        /// </summary>
        public List<byte> CheckScriptHps { get; set; } = new();

        /// <summary>
        /// ID of the associated sectors(auto editable)
        /// </summary>
        public ushort Sector { get; set; }

        /// <summary>
        /// Enter the name you used when creating the spawn action.
        /// </summary>
        public string ChangeSpawnAction { get; set; } = string.Empty;

        /// <summary>
        /// Specifies the ID of the destination specified by the box spawn protected.
        /// </summary>
        public ushort ProtectionTarget { get; set; }

        /// <summary>
        /// Unit [ms] (Specifies whether to create a monster, who died after a few seconds. Value of 0 is not used for the responder.)
        /// </summary>
        public float RespawnTime { get; set; }

        /// <summary>
        /// Step index of monster spawn.
        /// </summary>
        public byte Step { get; set; }

        /// <summary>
        /// Monster Respawn Type.
        /// </summary>
        public RespawnType RespawnType { get; set; }

        /// <summary>
        /// Respawn Condition ID.
        /// </summary>
        public uint RespawnCondition { get; set; }

        /// <summary>
        /// GroupID
        /// </summary>
        public uint GroupId { get; set; }

        public VMonsterSpawnBox()
        {
        }

        internal VMonsterSpawnBox(XmlNode xml) : base(xml)
        {
            Monsters = Enumerable
                .Range(1, 10)
                .Select(id => new VMonster(xml.GetUInt32($"m_iMonsterID{id}"), xml.GetEnum<MonsterSpawnType>($"m_eType{id}"), xml.GetUInt32($"m_iChance{id}")))
                .ToList();
            CreationPositionType = xml.GetEnum<CreationPositionType>("m_eCreationPositionType");
            MoveType = xml.GetEnum<MoveType>("m_eMoveType");
            CreationCondition = xml.GetEnum<CreationConditionType>("m_eCreationCondition");
            CreationEffectFile = xml.GetString("m_CreationEffectFile");
            WaitCreationDelayTime = xml.GetSingle("m_fWaitCreationDelayTime");
            WaitCreationSequenceTime = xml.GetSingle("m_fWaitCreationSequenceTime");
            WaitCreationMaxWave = xml.GetByte("m_iWaitCreationMaxWave");
            MaxEntityCount = xml.GetByte("m_iMaxEntityCount");
            WaitCreationSequenceType = xml.GetEnum<WaitCreationSequenceType>("m_eWaitCreationSequenceType");
            Waypoint = xml.GetUInt32("m_iWaypoint");
            AggroGroup = xml.GetUInt16("m_iAggroGroupID");
            AggroDistance = xml.GetUInt32("m_iAggroDistance");
            AggroMaxCount = xml.GetUInt16("m_iAggroMaxCount");
            LookRatio = xml.GetSingle("m_fLookRatio");
            ShowSight = xml.GetBool("m_bShowSight");
            ObjectKey = xml.GetString("m_szObjectKey");
            ScriptType = xml.GetEnum<ScriptType>("m_eScriptType");
            CheckScriptHps = Enumerable.Range(1, 5).Select(id => xml.GetByte($"m_iCheckScriptHP{id}")).ToList();
            Sector = xml.GetUInt16("m_iSectorID");
            ChangeSpawnAction = xml.GetString("m_ChangeSpawnAction");
            ProtectionTarget = xml.GetUInt16("m_ProtectionTarget");
            RespawnTime = xml.GetSingle("m_RespawnTime");
            Step = xml.GetByte("m_iStep");
            RespawnType = xml.GetEnum<RespawnType>("m_eRespawnType");
            RespawnCondition = xml.GetUInt32("m_iRespawnCondition");
            GroupId = xml.GetUInt32("m_iGroupID");
        }
    }
}