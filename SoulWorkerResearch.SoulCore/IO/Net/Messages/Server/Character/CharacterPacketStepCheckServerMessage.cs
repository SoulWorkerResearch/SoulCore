using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterPacketStepCheckServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.PacketStepCheck;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterPacketStepCheckServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }

    #endregion Body

    #region Constructors

    internal CharacterPacketStepCheckServerMessage(BinaryReader reader) => CharacterId = reader.ReadInt32();

    #endregion Constructors
}
