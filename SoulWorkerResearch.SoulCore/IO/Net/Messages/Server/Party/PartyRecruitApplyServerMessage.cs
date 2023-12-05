using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Party;

[ServerMessage(Group, Command)]
public readonly struct PartyRecruitApplyServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Party;
    public const PartyOpcode Command = PartyOpcode.RecruitApply;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(PartyRecruitApplyServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Result { get; }
    public int CharacterId { get; }
    public uint RecruitId { get; }
    public int MasterCharacterId { get; }
    public byte PartyGroupType { get; }
    public IEnumerable<PartyMember> Members { get; }

    #endregion Body

    #region Constructors

    internal PartyRecruitApplyServerMessage(BinaryReader reader)
    {
        Result = reader.ReadInt32();
        CharacterId = reader.ReadInt32();
        RecruitId = reader.ReadUInt32();
        MasterCharacterId = reader.ReadInt32();
        PartyGroupType = reader.ReadByte();

        var count = reader.ReadByte();
        Members = Enumerable.Repeat(0, count).Select(_ => new PartyMember(reader)).ToArray();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    public readonly struct PartyMember
    {
        #region Body

        public int MemberId { get; }
        public string Name { get; }
        public byte Level { get; }
        public Defines.Character Class { get; }
        public Advancement Advancement { get; }
        public uint ProfilePhotoId { get; }
        public int LocationId { get; }
        public int Channel { get; }
        public int MaxHp { get; }
        public int Hp { get; }
        public bool Login { get; }
        public MapEntity MapId { get; }

        #endregion Body

        #region Constructors

        internal PartyMember(BinaryReader reader)
        {
            MemberId = reader.ReadInt32();
            Name = reader.ReadUTF16UnicodeString();
            Level = reader.ReadByte();
            Class = reader.ReadClass();
            Advancement = reader.ReadClassAdvancement();
            ProfilePhotoId = reader.ReadUInt32();
            LocationId = reader.ReadInt32();
            Channel = reader.ReadInt32();
            MaxHp = reader.ReadInt32();
            Hp = reader.ReadInt32();
            Login = reader.ReadBoolean();
            MapId = new MapEntity(reader);
        }

        #endregion Constructors
    }

    #endregion DataTypes
}
