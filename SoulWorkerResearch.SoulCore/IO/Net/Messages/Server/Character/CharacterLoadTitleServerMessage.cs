using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

/// <summary>
/// This packet no have content.
/// </summary>
[ServerMessage(Group, Command)]
public readonly struct CharacterLoadTitleServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.LoadTitle;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterLoadTitleServerMessage _) => new(Group, Command);

    #endregion Operators
}
