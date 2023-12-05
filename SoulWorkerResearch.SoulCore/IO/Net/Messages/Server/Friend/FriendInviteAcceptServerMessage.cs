using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendInviteAcceptServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.InviteAccept;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendInviteAcceptServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; } = reader.ReadInt32();
    public int TargetCharacterId { get; } = reader.ReadInt32();
    public string TargetCharacterName { get; } = reader.ReadUTF16UnicodeString();
    public bool Accept { get; } = reader.ReadBoolean();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
