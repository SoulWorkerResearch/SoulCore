using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatTradeServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Trade;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatTradeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string Value { get; }

    #endregion Body

    #region Constructors

    public ChatTradeServerMessage(BinaryReader br) => Value = br.ReadUTF16UnicodeString();

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
