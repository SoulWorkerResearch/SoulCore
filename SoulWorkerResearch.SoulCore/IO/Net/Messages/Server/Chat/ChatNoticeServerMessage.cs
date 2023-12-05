using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatNoticeServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Notice;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatNoticeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte Type { get; } = reader.ReadByte();
    public string Message { get; } = reader.ReadUTF16UnicodeString();
    public string Color { get; } = reader.ReadUTF8UnicodeString();
    public int MessageCode { get; } = reader.ReadInt32();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
