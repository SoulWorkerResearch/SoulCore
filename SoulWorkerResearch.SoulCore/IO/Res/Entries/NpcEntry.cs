global using NpcKeyType = System.UInt32;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record NpcEntry : ITableEntry<NpcKeyType>
{
    public const string TableName = "tb_Npc";

    public NpcKeyType Id { get; }
    public ushort v6 { get; }
    public byte v7 { get; }
    public string v8 { get; }
    public uint v9 { get; }
    public uint v10 { get; }
    public uint v11 { get; }
    public uint v12 { get; }
    public uint v13 { get; }
    public byte v14 { get; }
    public uint v15 { get; }
    public byte v16 { get; }
    public byte v17 { get; }
    public uint v18 { get; }
    public byte v19 { get; }
    public uint v20 { get; }
    public byte v21 { get; }
    public uint v22 { get; }
    public ushort v23 { get; }
    public ushort v24 { get; }
    public ushort v25 { get; }
    public byte v26 { get; }
    public byte v27 { get; }
    public byte v28 { get; }
    public byte v29 { get; }
    public byte v30 { get; }
    public byte v31 { get; }
    public ushort v32 { get; }
    public ushort v33 { get; }
    public ushort v34 { get; }
    public string v35 { get; }
    public byte v36 { get; }
    public uint v37 { get; }
    public uint v38 { get; }
    public string v39 { get; }
    public ushort v40 { get; }
    public ushort v41 { get; }
    public ushort v42 { get; }
    public ushort v43 { get; }
    public ushort v44 { get; }
    public ushort v45 { get; }
    public ushort v46 { get; }
    public ushort v47 { get; }
    public ushort v48 { get; }
    public ushort v49 { get; }
    public ushort v50 { get; }
    public ushort v51 { get; }
    public ushort v52 { get; }
    public ushort v53 { get; }
    public ushort v54 { get; }
    public ushort v55 { get; }
    public string v56 { get; }
    public string v57 { get; }
    public string v58 { get; }
    public string v59 { get; }
    public string v60 { get; }

    public NpcEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt32();
        v6 = reader.ReadUInt16();
        v7 = reader.ReadByte();
        v8 = reader.ReadUTF16UnicodeString();
        v9 = reader.ReadUInt32();
        v10 = reader.ReadUInt32();
        v11 = reader.ReadUInt32();
        v12 = reader.ReadUInt32();
        v13 = reader.ReadUInt32();
        v14 = reader.ReadByte();
        v15 = reader.ReadUInt32();
        v16 = reader.ReadByte();
        v17 = reader.ReadByte();
        v18 = reader.ReadUInt32();
        v19 = reader.ReadByte();
        v20 = reader.ReadUInt32();
        v21 = reader.ReadByte();
        v22 = reader.ReadUInt32();
        v23 = reader.ReadUInt16();
        v24 = reader.ReadUInt16();
        v25 = reader.ReadUInt16();
        v26 = reader.ReadByte();
        v27 = reader.ReadByte();
        v28 = reader.ReadByte();
        v29 = reader.ReadByte();
        v30 = reader.ReadByte();
        v31 = reader.ReadByte();
        v32 = reader.ReadUInt16();
        v33 = reader.ReadUInt16();
        v34 = reader.ReadUInt16();
        v35 = reader.ReadUTF16UnicodeString();
        v36 = reader.ReadByte();
        v37 = reader.ReadUInt32();
        v38 = reader.ReadUInt32();
        v39 = reader.ReadUTF16UnicodeString();
        v40 = reader.ReadUInt16();
        v41 = reader.ReadUInt16();
        v42 = reader.ReadUInt16();
        v43 = reader.ReadUInt16();
        v44 = reader.ReadUInt16();
        v45 = reader.ReadUInt16();
        v46 = reader.ReadUInt16();
        v47 = reader.ReadUInt16();
        v48 = reader.ReadUInt16();
        v49 = reader.ReadUInt16();
        v50 = reader.ReadUInt16();
        v51 = reader.ReadUInt16();
        v52 = reader.ReadUInt16();
        v53 = reader.ReadUInt16();
        v54 = reader.ReadUInt16();
        v55 = reader.ReadUInt16();
        v56 = reader.ReadUTF16UnicodeString();
        v57 = reader.ReadUTF16UnicodeString();
        v58 = reader.ReadUTF16UnicodeString();
        v59 = reader.ReadUTF16UnicodeString();
        v60 = reader.ReadUTF16UnicodeString();
    }
}

// https://youtu.be/ze0HkbcF3_g
