using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Chat;

[ServerMessage(Group, Command)]
public readonly struct ChatMegaphoneServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Chat;
    public const ChatOpcode Command = ChatOpcode.Megaphone;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChatMegaphoneServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte InventoryType { get; }
    public short Slot { get; }
    public int CharacterId { get; }
    public string CharacterName { get; }
    public string Message { get; }

    #endregion Body

    #region Constructors

    public ChatMegaphoneServerMessage(BinaryReader br)
    {
        InventoryType = br.ReadByte();
        Slot = br.ReadInt16();
        CharacterId = br.ReadInt32();
        CharacterName = br.ReadUTF16UnicodeString();
        Message = br.ReadUTF16UnicodeString();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
