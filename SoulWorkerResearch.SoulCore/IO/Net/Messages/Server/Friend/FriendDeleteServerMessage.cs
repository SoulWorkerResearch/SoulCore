using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendDeleteServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.Delete;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendDeleteServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public bool OnMessage { get; }

    #endregion Body

    #region Constructors

    internal FriendDeleteServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        OnMessage = reader.ReadBoolean();
    }

    #endregion Constructors
}
