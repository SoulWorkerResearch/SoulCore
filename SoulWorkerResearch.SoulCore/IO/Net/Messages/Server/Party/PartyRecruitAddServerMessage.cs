using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Party;

[ServerMessage(Group, Command)]
public readonly struct PartyRecruitAddServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Party;
    public const PartyOpcode Command = PartyOpcode.RecruitAdd;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(PartyRecruitAddServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public uint PartyId { get; }
    public string Message { get; }
    public short MinLevel { get; }
    public short MaxLevel { get; }
    public byte Purpose { get; }
    public byte UserCount { get; }
    public int RemainTime { get; }
    public uint PurposeMapId { get; }
    public uint RecruitId { get; }
    public Character Master { get; }
    public byte PartyGroupType { get; }

    #endregion Body

    #region Constructors

    internal PartyRecruitAddServerMessage(BinaryReader reader)
    {
        PartyId = reader.ReadUInt32();
        Message = reader.ReadUTF16UnicodeString();
        MinLevel = reader.ReadInt16();
        MaxLevel = reader.ReadInt16();
        Purpose = reader.ReadByte();
        var masterCharacterName = reader.ReadUTF16UnicodeString();
        UserCount = reader.ReadByte();
        RemainTime = reader.ReadInt32();
        PurposeMapId = reader.ReadUInt32();
        RecruitId = reader.ReadUInt32();
        var masterCharacaterId = reader.ReadInt32();
        Master = new Character(masterCharacaterId, masterCharacterName);
        PartyGroupType = reader.ReadByte();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    public readonly struct Character
    {
        public int Id { get; }
        public string Name { get; }

        public Character(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    #endregion DataTypes
}
