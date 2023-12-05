using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendBlocklistAddServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.BlocklistAdd;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendBlocklistAddServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string CharacterName { get; } = reader.ReadUTF16UnicodeString();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
