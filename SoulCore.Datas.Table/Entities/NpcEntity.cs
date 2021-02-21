using SoulCore.Extensions;
using System;
using System.IO;

namespace SoulCore.Data.Bin.Table.Entities
{
    using KeyType = UInt32;

    [Table("tb_Npc")]
    public sealed class NpcEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public ushort v6 { get; set; }
        public byte v7 { get; set; }
        public string v8 { get; set; }
        public uint v9 { get; set; }
        public uint v10 { get; set; }
        public uint v11 { get; set; }
        public uint v12 { get; set; }
        public uint v13 { get; set; }
        public byte v14 { get; set; }
        public uint v15 { get; set; }
        public byte v16 { get; set; }
        public byte v17 { get; set; }
        public uint v18 { get; set; }
        public byte v19 { get; set; }
        public uint v20 { get; set; }
        public byte v21 { get; set; }
        public uint v22 { get; set; }
        public ushort v23 { get; set; }
        public ushort v24 { get; set; }
        public ushort v25 { get; set; }
        public byte v26 { get; set; }
        public byte v27 { get; set; }
        public byte v28 { get; set; }
        public byte v29 { get; set; }
        public byte v30 { get; set; }
        public byte v31 { get; set; }
        public ushort v32 { get; set; }
        public ushort v33 { get; set; }
        public ushort v34 { get; set; }
        public string v35 { get; set; }
        public byte v36 { get; set; }
        public uint v37 { get; set; }
        public uint v38 { get; set; }
        public string v39 { get; set; }
        public ushort v40 { get; set; }
        public ushort v41 { get; set; }
        public ushort v42 { get; set; }
        public ushort v43 { get; set; }
        public ushort v44 { get; set; }
        public ushort v45 { get; set; }
        public ushort v46 { get; set; }
        public ushort v47 { get; set; }
        public ushort v48 { get; set; }
        public ushort v49 { get; set; }
        public ushort v50 { get; set; }
        public ushort v51 { get; set; }
        public ushort v52 { get; set; }
        public ushort v53 { get; set; }
        public ushort v54 { get; set; }
        public ushort v55 { get; set; }
        public string v56 { get; set; }
        public string v57 { get; set; }
        public string v58 { get; set; }
        public string v59 { get; set; }
        public string v60 { get; set; }

        public NpcEntity(BinaryReader br)
        {
            Id = br.ReadUInt32();
            v6 = br.ReadUInt16();
            v7 = br.ReadByte();
            v8 = br.ReadCharacterLengthUnicodeString();
            v9 = br.ReadUInt32();
            v10 = br.ReadUInt32();
            v11 = br.ReadUInt32();
            v12 = br.ReadUInt32();
            v13 = br.ReadUInt32();
            v14 = br.ReadByte();
            v15 = br.ReadUInt32();
            v16 = br.ReadByte();
            v17 = br.ReadByte();
            v18 = br.ReadUInt32();
            v19 = br.ReadByte();
            v20 = br.ReadUInt32();
            v21 = br.ReadByte();
            v22 = br.ReadUInt32();
            v23 = br.ReadUInt16();
            v24 = br.ReadUInt16();
            v25 = br.ReadUInt16();
            v26 = br.ReadByte();
            v27 = br.ReadByte();
            v28 = br.ReadByte();
            v29 = br.ReadByte();
            v30 = br.ReadByte();
            v31 = br.ReadByte();
            v32 = br.ReadUInt16();
            v33 = br.ReadUInt16();
            v34 = br.ReadUInt16();
            v35 = br.ReadCharacterLengthUnicodeString();
            v36 = br.ReadByte();
            v37 = br.ReadUInt32();
            v38 = br.ReadUInt32();
            v39 = br.ReadCharacterLengthUnicodeString();
            v40 = br.ReadUInt16();
            v41 = br.ReadUInt16();
            v42 = br.ReadUInt16();
            v43 = br.ReadUInt16();
            v44 = br.ReadUInt16();
            v45 = br.ReadUInt16();
            v46 = br.ReadUInt16();
            v47 = br.ReadUInt16();
            v48 = br.ReadUInt16();
            v49 = br.ReadUInt16();
            v50 = br.ReadUInt16();
            v51 = br.ReadUInt16();
            v52 = br.ReadUInt16();
            v53 = br.ReadUInt16();
            v54 = br.ReadUInt16();
            v55 = br.ReadUInt16();
            v56 = br.ReadCharacterLengthUnicodeString();
            v57 = br.ReadCharacterLengthUnicodeString();
            v58 = br.ReadCharacterLengthUnicodeString();
            v59 = br.ReadCharacterLengthUnicodeString();
            v60 = br.ReadCharacterLengthUnicodeString();
        }
    }
}

// https://youtu.be/ze0HkbcF3_g
