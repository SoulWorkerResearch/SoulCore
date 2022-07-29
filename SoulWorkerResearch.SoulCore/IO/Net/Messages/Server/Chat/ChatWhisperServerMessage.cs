using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatWhisperServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Whisper;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatWhisperServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string SenderCharacterName { get; }
    public string ReceiverCharacterName { get; }
    public string Message { get; }
    public int Result { get; }
    public int SenderCharacterId { get; }

    #endregion Body

    #region Constructors

    public ChatWhisperServerMessage(BinaryReader br)
    {
        SenderCharacterName = br.ReadUTF16UnicodeString();
        ReceiverCharacterName = br.ReadUTF16UnicodeString();
        Message = br.ReadUTF16UnicodeString();
        Result = br.ReadInt32();
        SenderCharacterId = br.ReadInt32();
    }

    #endregion Constructors
}
