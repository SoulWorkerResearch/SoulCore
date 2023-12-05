using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatNormalServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Normal;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatNormalServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ChatType ChatType { get; } = reader.ReadChatType();
    public string Message { get; } = reader.ReadUTF16UnicodeString();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
