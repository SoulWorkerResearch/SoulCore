﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.League;

[ServerMessage(Group, Command)]
public readonly struct LeagueOverlapNameServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.League;
    public const LeagueOpcode Command = LeagueOpcode.OverlapName;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LeagueOverlapNameServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal LeagueOverlapNameServerMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors
}