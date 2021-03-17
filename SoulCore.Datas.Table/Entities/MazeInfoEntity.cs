using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt16;

    [Table("tb_Maze_Info")]
    public sealed class MazeInfoEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; set; }
        public byte Type { get; set; }
        public ushort Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte MinLevel { get; set; }
        public byte Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        public ushort Unknown12 { get; set; }
        public ushort Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public byte EntranceCount { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public uint Ticket { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public uint StartEventBox { get; set; }
        public ushort Unknown27 { get; set; }
        public ushort Unknown28 { get; set; }
        public ushort Unknown29 { get; set; }
        public string Batch { get; set; }
        public string Unknown31 { get; set; }
        public string LuaScript { get; set; }
        public string BGMMaze { get; set; }
        public string BGMBoss { get; set; }
        public string Map { get; set; }
        public ushort Unknown36 { get; set; }
        public ushort Unknown37 { get; set; }
        public byte Unknown38 { get; set; }
        public ushort Unknown39 { get; set; }
        public string LoadingBackground { get; set; }
        public string Unknown41 { get; set; }
        public ushort Unknown42 { get; set; }
        public ushort Portal { get; set; }
        public uint Unknown44 { get; set; }
        public uint Unknown45 { get; set; }
        public ushort District { get; set; }
        public uint Unknown47 { get; set; }
        public uint Unknown48 { get; set; }
        public uint Unknown49 { get; set; }
        public uint Unknown50 { get; set; }
        public uint Unknown51 { get; set; }
        public byte Unknown52 { get; set; }
        public byte Unknown53 { get; set; }
        public string Unknown54 { get; set; }
        public byte Unknown55 { get; set; }
        public uint Unknown56 { get; set; }
        public byte Unknown57 { get; set; }

        public MazeInfoEntity(BinaryReader br)
        {
            Id = br.ReadUInt16();
            Type = br.ReadByte();
            Unknown7 = br.ReadUInt16();
            Unknown8 = br.ReadByte();
            MinLevel = br.ReadByte();
            Unknown10 = br.ReadByte();
            Unknown11 = br.ReadUInt16();
            Unknown12 = br.ReadUInt16();
            Unknown13 = br.ReadUInt16();
            Unknown14 = br.ReadByte();
            EntranceCount = br.ReadByte();
            Unknown16 = br.ReadByte();
            Unknown17 = br.ReadByte();
            Unknown18 = br.ReadByte();
            Unknown19 = br.ReadByte();
            Ticket = br.ReadUInt32();
            Unknown21 = br.ReadByte();
            Unknown22 = br.ReadByte();
            Unknown23 = br.ReadByte();
            Unknown24 = br.ReadByte();
            Unknown25 = br.ReadByte();
            StartEventBox = br.ReadUInt32();
            Unknown27 = br.ReadUInt16();
            Unknown28 = br.ReadUInt16();
            Unknown29 = br.ReadUInt16();
            Batch = br.ReadCharacterLengthUnicodeString();
            Unknown31 = br.ReadCharacterLengthUnicodeString();
            LuaScript = br.ReadCharacterLengthUnicodeString();
            BGMMaze = br.ReadCharacterLengthUnicodeString();
            BGMBoss = br.ReadCharacterLengthUnicodeString();
            Map = br.ReadCharacterLengthUnicodeString();
            Unknown36 = br.ReadUInt16();
            Unknown37 = br.ReadUInt16();
            Unknown38 = br.ReadByte();
            Unknown39 = br.ReadUInt16();
            LoadingBackground = br.ReadCharacterLengthUnicodeString();
            Unknown41 = br.ReadCharacterLengthUnicodeString();
            Unknown42 = br.ReadUInt16();
            Portal = br.ReadUInt16();
            Unknown44 = br.ReadUInt32();
            Unknown45 = br.ReadUInt32();
            District = br.ReadUInt16();
            Unknown47 = br.ReadUInt32();
            Unknown48 = br.ReadUInt32();
            Unknown49 = br.ReadUInt32();
            Unknown50 = br.ReadUInt32();
            Unknown51 = br.ReadUInt32();
            Unknown52 = br.ReadByte();
            Unknown53 = br.ReadByte();
            Unknown54 = br.ReadCharacterLengthUnicodeString();
            Unknown55 = br.ReadByte();
            Unknown56 = br.ReadUInt32();
            Unknown57 = br.ReadByte();
        }
    }
}

// https://youtu.be/l74Ot_2kuNs
