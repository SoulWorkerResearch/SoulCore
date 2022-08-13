using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterChangeSlotServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ChangeSlot;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterChangeSlotServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; }
    public Entry Src { get; }
    public Entry Dst { get; }
    public int ErrorCode { get; }

    #endregion Body

    #region Constructors

    internal CharacterChangeSlotServerMessage(BinaryReader reader)
    {
        AccountId = reader.ReadInt32();

        int srcCharacterId = reader.ReadInt32();
        int dstCharacterId = reader.ReadInt32();

        ErrorCode = reader.ReadInt32();

        byte srcSlotId = reader.ReadByte();
        byte dstSlotId = reader.ReadByte();

        Src = new(srcCharacterId, srcSlotId);
        Dst = new(dstCharacterId, dstSlotId);
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region Types

    public readonly struct Entry
    {
        public int CharacterId { get; }
        public byte SlotId { get; }

        public Entry(int characterId, byte slotId)
        {
            CharacterId = characterId;
            SlotId = slotId;
        }
    }

    #endregion Types
}
