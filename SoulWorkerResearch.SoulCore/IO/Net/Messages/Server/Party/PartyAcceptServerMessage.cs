using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Party;

[ServerMessage(Group, Command)]
public readonly struct PartyAcceptServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Party;
    public const PartyOpcode Command = PartyOpcode.Accept;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(PartyAcceptServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }

    #endregion Body

    #region Constructors

    internal PartyAcceptServerMessage(BinaryReader reader) => CharacterId = reader.ReadInt32();

    #endregion Constructors
}
