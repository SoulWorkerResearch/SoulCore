using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendInviteServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.Invite;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendInviteServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string CharacterName { get; }

    #endregion Body

    #region Constructors

    internal FriendInviteServerMessage(BinaryReader reader) => CharacterName = reader.ReadUTF16UnicodeString();

    #endregion Constructors
}
