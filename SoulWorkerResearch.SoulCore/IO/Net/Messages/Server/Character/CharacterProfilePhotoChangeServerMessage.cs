using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterProfilePhotoChangeServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ProfilePhotoChange;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterProfilePhotoChangeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }

    #endregion Body

    #region Constructors

    internal CharacterProfilePhotoChangeServerMessage(BinaryReader reader) => CharacterId = reader.ReadInt32();

    #endregion Constructors
}
