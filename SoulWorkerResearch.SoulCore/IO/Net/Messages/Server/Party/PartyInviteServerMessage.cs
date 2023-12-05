using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Party;

[ServerMessage(Group, Command)]
public readonly struct PartyInviteServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Party;
    public const PartyOpcode Command = PartyOpcode.Invite;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(PartyInviteServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public Character Member { get; }
    public Character Master { get; }
    public int ServerId { get; }
    public int Result { get; }

    #endregion Body

    #region Constructors

    internal PartyInviteServerMessage(BinaryReader reader)
    {
        var memberCharacterName = reader.ReadUTF16UnicodeString();
        var masterCharacterName = reader.ReadUTF16UnicodeString();
        var memberCharacterId = reader.ReadInt32();
        var masterId = reader.ReadInt32();

        Member = new Character(memberCharacterId, memberCharacterName);
        Master = new Character(masterId, masterCharacterName);
        ServerId = reader.ReadInt32();
        Result = reader.ReadInt32();
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
