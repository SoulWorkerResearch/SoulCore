using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendInfoServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.Info;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendInfoServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; } = reader.ReadInt32();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
