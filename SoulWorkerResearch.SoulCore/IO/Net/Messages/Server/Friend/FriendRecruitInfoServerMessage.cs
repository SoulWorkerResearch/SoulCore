using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

/// <summary>
///     This packet no have content.
/// </summary>
[ServerMessage(Group, Command)]
public readonly struct FriendRecruitInfoServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.RecruitInfo;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendRecruitInfoServerMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
