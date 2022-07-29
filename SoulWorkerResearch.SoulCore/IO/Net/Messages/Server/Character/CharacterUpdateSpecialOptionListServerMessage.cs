using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterUpdateSpecialOptionListServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.UpdateSpecialOptionList;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterUpdateSpecialOptionListServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Character { get; }

    #endregion Body

    #region Constructors

    internal CharacterUpdateSpecialOptionListServerMessage(BinaryReader reader) => Character = reader.ReadInt32();

    #endregion Constructors
}
