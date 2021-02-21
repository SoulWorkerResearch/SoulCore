using SoulCore.Extensions;
using SoulCore.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.IO.Network.PacketSharedStructure
{
    public readonly struct CharacterPacketSharedStructure
    {
        public readonly struct StatsInfo
        {
            public readonly struct StatInfo
            {
                public uint Current { get; init; }
                public uint Max { get; init; }

                internal StatInfo(BinaryReader br)
                {
                    Current = br.ReadUInt32();
                    Max = br.ReadUInt32();
                }
            }

            /// <summary>
            /// Health Point
            /// </summary>
            public StatInfo Hp { get; init; }

            /// <summary>
            /// Soul Gain
            /// </summary>
            public StatInfo Sg { get; init; }

            /// <summary>
            /// Soul Vapor
            /// </summary>
            public StatInfo Sv { get; init; }

            /// <summary>
            /// Stamina
            /// </summary>
            public StatInfo St { get; init; }

            /// <summary>
            /// IDK
            /// </summary>
            public StatInfo Fd { get; init; }

            public float AttackSpeed { get; init; }
            public float MoveSpeed { get; init; }

            internal StatsInfo(BinaryReader br)
            {
                Hp = new(br);
                Sg = new(br);
                Sv = new(br);
                St = new(br);
                Fd = new(br);
                AttackSpeed = br.ReadSingle();
                MoveSpeed = br.ReadSingle();
            }
        }

        public readonly struct AppearanceInfo
        {
            public readonly struct HairInfo
            {
                public ushort Style { get; init; }
                public ushort Color { get; init; }

                internal HairInfo(BinaryReader br)
                {
                    Style = br.ReadUInt16();
                    Color = br.ReadUInt16();
                }
            }

            public ushort _1 { get; }
            public HairInfo Hair { get; init; }
            public ushort EyeColor { get; init; }
            public ushort SkinColor { get; init; }
            public HairInfo EquippedHair { get; init; }
            public ushort EquippedEyeColor { get; init; }
            public ushort EquippedSkinColor { get; init; }

            internal AppearanceInfo(BinaryReader br)
            {
                _1 = br.ReadUInt16();
                Hair = new(br);
                EyeColor = br.ReadUInt16();
                SkinColor = br.ReadUInt16();
                EquippedHair = new(br);
                EquippedEyeColor = br.ReadUInt16();
                EquippedSkinColor = br.ReadUInt16();
            }
        }

        public readonly struct GearInfo
        {
            public static readonly GearInfo Empty = new() { PrototypeId = -1 };

            public byte UpgradeLevel { get; init; }
            public int PrototypeId { get; init; }

            internal GearInfo(BinaryReader br)
            {
                UpgradeLevel = br.ReadByte();
                PrototypeId = br.ReadInt32();
            }
        }

        public readonly struct CostumeInfos
        {
            public readonly struct CostumeInfo
            {
                public static readonly CostumeInfo Empty = new() { Serial = -1, PrototypeId = -1 };

                public long Serial { get; init; }
                public int PrototypeId { get; init; }
                public uint Color { get; init; }

                internal CostumeInfo(BinaryReader br)
                {
                    Serial = br.ReadInt64();
                    PrototypeId = br.ReadInt32();
                    Color = br.ReadUInt32();
                }
            }

            public IEnumerable<CostumeInfo> Battle { get; init; }
            public IEnumerable<CostumeInfo> View { get; init; }

            internal CostumeInfos(BinaryReader br)
            {
                (CostumeInfo Battle, CostumeInfo View)[]? items = Enumerable.Range(0, Defines.EquipableFashionStorageMaxCapacity).Select(_ => (Battle: new CostumeInfo(br), View: new CostumeInfo(br))).ToArray();

                Battle = items.Select(s => s.Battle).ToArray();
                View = items.Select(s => s.View).ToArray();
            }
        }

        public readonly struct TitleInfo
        {
            public uint Prefix { get; init; }
            public uint Suffix { get; init; }

            internal TitleInfo(BinaryReader br)
            {
                Prefix = br.ReadUInt32();
                Suffix = br.ReadUInt32();
            }
        };

        public readonly struct LeagueInfo
        {
            public readonly struct CardInfo
            {
                public ushort Design { get; init; }
                public ushort BackDesign { get; init; }

                internal CardInfo(BinaryReader br)
                {
                    Design = br.ReadUInt16();
                    BackDesign = br.ReadUInt16();
                }
            };

            public int Id { get; init; }
            public string Name { get; init; }
            public CardInfo Card { get; init; }

            internal LeagueInfo(BinaryReader br)
            {
                Id = br.ReadInt32();
                Name = br.ReadCharacterLengthUnicodeString();
                Card = new(br);
            }
        };

        public readonly struct PrivateShopInfo
        {
            public byte Type { get; init; }
            public string Title { get; init; }

            internal PrivateShopInfo(BinaryReader br)
            {
                Type = br.ReadByte();
                Title = br.ReadCharacterLengthUnicodeString();
            }
        };

        public readonly struct BuffInfo
        {
            public int Id { get; init; }
            public float Time { get; init; }
            public byte Count { get; init; }
            public uint OwnerId { get; init; }
            public byte Show { get; init; }

            internal BuffInfo(BinaryReader br)
            {
                Id = br.ReadInt32();
                Time = br.ReadSingle();
                Count = br.ReadByte();
                OwnerId = br.ReadUInt32();
                Show = br.ReadByte();
            }
        };

        public readonly struct FpInfo
        {
            public short Fp { get; init; }
            public short BonusFp { get; init; }
            public short PcBangFp { get; init; }

            internal FpInfo(BinaryReader br)
            {
                Fp = br.ReadInt16();
                BonusFp = br.ReadInt16();
                PcBangFp = br.ReadInt16();
            }
        };

        public readonly struct EchelonInfo
        {
            public byte Level { get; init; }
            public int Exp { get; init; }

            internal EchelonInfo(BinaryReader br)
            {
                Level = br.ReadByte();
                Exp = br.ReadInt32();
            }
        };

        public int Id { get; init; }
        public string Name { get; init; }
        public Class Class { get; init; }
        public ClassAdvancement Advancement { get; init; }
        public uint Photo { get; init; }
        public AppearanceInfo Appearance { get; init; }
        public byte Level { get; init; }
        public byte Faction { get; init; }
        public int AccountId { get; init; }
        public byte GameMasterPower { get; init; }
        public int PvPKillCount { get; init; }
        public GearInfo WeaponItem { get; init; }
        public GearInfo SubWeaponItem { get; init; }
        public CostumeInfos CostumesItems { get; init; }
        public uint ActiveBroachEffect { get; init; }
        public TitleInfo Title { get; init; }
        public LeagueInfo League { get; init; }
        public StatsInfo Stats { get; init; }
        public PrivateShopInfo Shop { get; init; }
        public FpInfo Fp { get; init; }
        public EchelonInfo Echelon { get; init; }
        public byte BattlePose { get; init; }
        public uint Status { get; init; }
        public IEnumerable<BuffInfo> Buffs { get; init; }
        public byte Slot { get; init; }
        public int EqualizerId { get; init; }
        public int _1 { get; init; }
        public byte _2 { get; init; }
        public int _3 { get; init; }

        internal CharacterPacketSharedStructure(BinaryReader br)
        {
            Id = br.ReadInt32();
            Name = br.ReadCharacterLengthUnicodeString();
            Class = br.ReadClass();
            Advancement = br.ReadClassAdvancement();
            Photo = br.ReadUInt32();
            Appearance = new(br);
            Level = br.ReadByte();
            Faction = br.ReadByte();
            AccountId = br.ReadInt32();
            GameMasterPower = br.ReadByte();
            PvPKillCount = br.ReadInt32();
            WeaponItem = new(br);
            SubWeaponItem = new(br);
            CostumesItems = new(br);
            ActiveBroachEffect = br.ReadUInt32();
            Title = new(br);
            League = new(br);
            Stats = new(br);
            Shop = new(br);
            Fp = new(br);
            Echelon = new(br);
            BattlePose = br.ReadByte();
            Status = br.ReadUInt32();
            Buffs = Enumerable.Range(0, br.ReadByte()).Select(_ => new BuffInfo(br)).ToArray();
            Slot = br.ReadByte();
            EqualizerId = br.ReadInt32();
            _1 = br.ReadInt32();
            _2 = br.ReadByte();
            _3 = br.ReadInt32();
        }
    }
}