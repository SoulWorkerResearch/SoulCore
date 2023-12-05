using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatMegaphoneServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Megaphone;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatMegaphoneServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte InventoryType { get; } = reader.ReadByte();
    public short Slot { get; } = reader.ReadInt16();
    public int CharacterId { get; } = reader.ReadInt32();
    public string CharacterName { get; } = reader.ReadUTF16UnicodeString();
    public string Message { get; } = reader.ReadUTF16UnicodeString();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
