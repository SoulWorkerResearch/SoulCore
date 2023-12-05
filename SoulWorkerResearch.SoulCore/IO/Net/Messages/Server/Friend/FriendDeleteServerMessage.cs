using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendDeleteServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.Delete;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendDeleteServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; } = reader.ReadInt32();
    public bool OnMessage { get; } = reader.ReadBoolean();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
