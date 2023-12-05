using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.League;

[ServerMessage(Group, Command)]
public readonly struct LeagueWithdrawServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.League;
    public const LeagueOpcode Command = LeagueOpcode.Withdraw;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LeagueWithdrawServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal LeagueWithdrawServerMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
