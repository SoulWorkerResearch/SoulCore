using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatNormalClientMessage(int Person, ChatType Chat, string Message) : IBinaryOutMessage
{
    #region Opcode                             

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Normal;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatNormalClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Person);
        writer.Write(Chat);
        writer.Write(Message);
    }

    #endregion IBinaryConvertibleMessage
}
