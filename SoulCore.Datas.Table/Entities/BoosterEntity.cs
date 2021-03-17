using SoulCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt16;

    [Table("tb_Booster")]
    public sealed class BoosterEntity : ITableEntity<KeyType>
    {
        public sealed record Effect
        {
            public byte EffectType { get; set; }
            public byte ApplyType { get; set; }
            public float EffectValue { get; set; }
            public ushort EffectString { get; set; }

            public Effect(byte effectType, byte applyType, float effectValue, ushort effectString)
            {
                EffectType = effectType;
                ApplyType = applyType;
                EffectValue = effectValue;
                EffectString = effectString;
            }
        }

        public KeyType Id { get; set; }
        public ushort Group { get; set; }
        public List<Effect> Effects { get; set; }
        public ushort Info { get; set; }
        public byte DecreaseCondition { get; set; }
        public uint Time { get; set; }

        public BoosterEntity(BinaryReader br)
        {
            Id = br.ReadUInt16();
            Group = br.ReadUInt16();
            Effects = GetItems(br);
            Info = br.ReadUInt16();
            DecreaseCondition = br.ReadByte();
            Time = br.ReadUInt32();
        }

        private static List<Effect> GetItems(BinaryReader br)
        {
            IEnumerable<byte> effectTypes = br.ReadByteEnumerable(ItemsCount);
            IEnumerable<byte> applyTypes = br.ReadByteEnumerable(ItemsCount);
            IEnumerable<float> effectValues = br.ReadSingleArray(ItemsCount);
            IEnumerable<ushort> effectStrings = br.ReadUInt16Enumerable(ItemsCount);

            return IterateItems(effectTypes, applyTypes, effectValues, effectStrings)
                .Select(s => new Effect(s.Item1, s.Item2, s.Item3, s.Item4))
                .ToList();
        }

        private static IEnumerable<Tuple<T1, T2, T3, T4>> IterateItems<T1, T2, T3, T4>(IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, IEnumerable<T4> fourth)
        {
            IEnumerator<T1> e1 = first.GetEnumerator();
            IEnumerator<T2> e2 = second.GetEnumerator();
            IEnumerator<T3> e3 = third.GetEnumerator();
            IEnumerator<T4> e4 = fourth.GetEnumerator();

            while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
            {
                yield return Tuple.Create(e1.Current, e2.Current, e3.Current, e4.Current);
            }
        }

        private const byte ItemsCount = 8;
    }
}