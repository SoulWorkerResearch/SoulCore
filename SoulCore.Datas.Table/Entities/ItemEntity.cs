using SoulCore.Extensions;
using SoulCore.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_item")]
    public sealed class ItemEntity : ITableEntity<KeyType>
    {
        public sealed class Option
        {
            public byte Class { get; set; }
            public uint Type { get; set; }
            public int Value { get; set; }

            public Option(byte @class, uint id, int value) => (Class, Type, Value) = (@class, id, value);
        }

        public sealed class Specification
        {
            public uint Min { get; set; }
            public uint Max { get; set; }
            public uint Magic { get; set; }

            public Specification(uint min, uint max, uint magic) => (Min, Max, Magic) = (min, max, magic);
        }

        public KeyType Id { get; }
        public uint ClassifyId { get; set; }
        public byte Unknown7 { get; set; }
        public byte MaxSlots { get; set; }
        public ushort Unknown9 { get; set; }
        public uint SellPrice { get; set; }
        public uint BuyPrice { get; set; }
        public uint RecycleSellPrice { get; set; }
        public uint RecycleBuyPrice { get; set; }
        public ushort StackMax { get; set; }
        public byte BindType { get; set; }
        public uint Unknown16 { get; set; }
        public uint Unknown17 { get; set; }
        public uint Info { get; set; }
        public ushort MinLevel { get; set; }
        public Class Class { get; set; }
        public byte LimitSellType { get; set; }
        public byte SubType { get; set; }
        public byte CostumeSetType { get; set; }
        public uint CostumeSet { get; set; }
        public string SlotDisable { get; set; }
        public byte Endurance { get; set; }
        public byte UseValue { get; set; }
        public Specification AttackDamage { get; set; }
        public Specification Defence { get; set; }
        public IReadOnlyList<Option> Options { get; set; }
        public uint Unknown49 { get; set; }
        public uint Unknown50 { get; set; }
        public uint Unknown51 { get; set; }
        public ushort ItemReinforce { get; set; }
        public uint ReinforceOption { get; set; }
        public uint Title { get; set; }
        public uint Evolution { get; set; }
        public ushort Disassemble { get; set; }
        public uint Furniture { get; set; }
        public ushort CooltimeGroup { get; set; }
        public uint CooltimeValue { get; set; }
        public byte CooltimeSave { get; set; }
        public ushort EffectType { get; set; }
        public uint Effect { get; set; }
        public ushort Unknown63 { get; set; }
        public byte ItemCash { get; set; }
        public byte UsePeriodType { get; set; }
        public uint UsePeriodValue { get; set; }
        public byte Unknown67 { get; set; }
        public uint Unknown68 { get; set; }
        public byte SealingCnt { get; set; }
        public byte BreakCnt { get; set; }
        public uint SimilarGroup { get; set; }
        public uint Package { get; set; }

        public ItemEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            ClassifyId = br.ReadUInt32();
            Unknown7 = br.ReadByte();
            MaxSlots = br.ReadByte();
            Unknown9 = br.ReadUInt16();
            SellPrice = br.ReadUInt32();
            BuyPrice = br.ReadUInt32();
            RecycleSellPrice = br.ReadUInt32();
            RecycleBuyPrice = br.ReadUInt32();
            StackMax = br.ReadUInt16();
            BindType = br.ReadByte();
            Unknown16 = br.ReadUInt32();
            Unknown17 = br.ReadUInt32();
            Info = br.ReadUInt32();
            MinLevel = br.ReadUInt16();
            Class = br.ReadClass();
            LimitSellType = br.ReadByte();
            SubType = br.ReadByte();
            CostumeSetType = br.ReadByte();
            CostumeSet = br.ReadUInt32();
            SlotDisable = br.ReadByteLengthUnicodeString();
            Endurance = br.ReadByte();
            UseValue = br.ReadByte();
            AttackDamage = new(br.ReadUInt32(), br.ReadUInt32(), br.ReadUInt32());
            Defence = new(br.ReadUInt32(), br.ReadUInt32(), br.ReadUInt32());
            Options = ReadOptions(br);
            Unknown49 = br.ReadUInt32();
            Unknown50 = br.ReadUInt32();
            Unknown51 = br.ReadUInt32();
            ItemReinforce = br.ReadUInt16();
            ReinforceOption = br.ReadUInt32();
            Title = br.ReadUInt32();
            Evolution = br.ReadUInt32();
            Disassemble = br.ReadUInt16();
            Furniture = br.ReadUInt32();
            CooltimeGroup = br.ReadUInt16();
            CooltimeValue = br.ReadUInt32();
            CooltimeSave = br.ReadByte();
            EffectType = br.ReadUInt16();
            Effect = br.ReadUInt32();
            Unknown63 = br.ReadUInt16();
            ItemCash = br.ReadByte();
            UsePeriodType = br.ReadByte();
            UsePeriodValue = br.ReadUInt32();
            Unknown67 = br.ReadByte();
            Unknown68 = br.ReadUInt32();
            SealingCnt = br.ReadByte();
            BreakCnt = br.ReadByte();
            SimilarGroup = br.ReadUInt32();
            Package = br.ReadUInt32();
        }

        private static Option[] ReadOptions(BinaryReader br)
        {
            IEnumerable<byte> classes = br.ReadByteEnumerable(Defines.PerItemStatsCount);
            IEnumerable<uint> types = br.ReadUInt32Enumerable(Defines.PerItemStatsCount);
            IEnumerable<int> values = br.ReadInt32Enumerable(Defines.PerItemStatsCount);

            return GetItems(classes, types, values).Select(item => new Option(item.Item1, item.Item2, item.Item3)).ToArray();
        }

        private static IEnumerable<Tuple<T1, T2, T3>> GetItems<T1, T2, T3>(IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third)
        {
            IEnumerator<T1> e1 = first.GetEnumerator();
            IEnumerator<T2> e2 = second.GetEnumerator();
            IEnumerator<T3> e3 = third.GetEnumerator();

            while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
                yield return Tuple.Create(e1.Current, e2.Current, e3.Current);
        }
    }
}
