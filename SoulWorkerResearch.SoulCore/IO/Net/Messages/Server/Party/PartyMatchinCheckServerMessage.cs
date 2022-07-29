using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Party;

[ServerMessage(Group, Command)]
public readonly struct PartyMatchinCheckServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Party;
    public const PartyOpcode Command = PartyOpcode.MatchingCheck;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(PartyMatchinCheckServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal PartyMatchinCheckServerMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors
}
