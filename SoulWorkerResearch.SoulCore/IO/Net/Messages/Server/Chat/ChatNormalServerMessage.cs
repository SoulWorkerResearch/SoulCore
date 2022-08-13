using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatNormalServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Normal;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatNormalServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ChatType ChatType { get; }
    public string Message { get; }

    #endregion Body

    #region Constructors

    public ChatNormalServerMessage(BinaryReader br)
    {
        ChatType = br.ReadChatType();
        Message = br.ReadUTF16UnicodeString();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
