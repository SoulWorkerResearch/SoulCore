using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatNoticeServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Notice;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatNoticeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte Type { get; }
    public string Message { get; }
    public string Color { get; }
    public int MessageCode { get; }

    #endregion Body

    #region Constructors

    public ChatNoticeServerMessage(BinaryReader br)
    {
        Type = br.ReadByte();
        Message = br.ReadUTF16UnicodeString();
        Color = br.ReadUTF8UnicodeString();
        MessageCode = br.ReadInt32();
    }

    #endregion Constructors
}
