using SoulWorkerResearch.SoulCore.IO.Datas.World.Table.Types;

namespace SoulWorkerResearch.SoulCore.IO.Datas.World.Table.EventBox
{
    public sealed record VMonster
    {
        /// <summary>
        /// Monster ID
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Monster Spawn Type
        /// </summary>
        public MonsterSpawnType Type { get; set; }

        /// <summary>
        /// Monster Chance(0~10000)
        ///
        /// M07_CONCRETEJUNGLE_EP_04.vbatch
        /// <m_iChance4 type="0" value="100000" />
        /// </summary>
        public uint Chance { get; set; }

        public VMonster()
        {
        }

        public VMonster(uint id, MonsterSpawnType type, uint chance) =>
            (Id, Type, Chance) = (id, type, chance);
    }
}
