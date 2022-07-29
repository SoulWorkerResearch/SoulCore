using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendInviteAcceptServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.InviteAccept;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendInviteAcceptServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public int TargetCharacterId { get; }
    public string TargetCharacterName { get; }
    public bool Accept { get; }

    #endregion Body

    #region Constructors

    internal FriendInviteAcceptServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        TargetCharacterId = reader.ReadInt32();
        TargetCharacterName = reader.ReadUTF16UnicodeString();
        Accept = reader.ReadBoolean();
    }

    #endregion Constructors
}
