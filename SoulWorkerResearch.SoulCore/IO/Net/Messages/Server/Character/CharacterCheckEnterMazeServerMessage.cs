using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

/// <summary>
/// This packet no have content.
/// </summary>
[ServerMessage(Group, Command)]
public readonly struct CharacterCheckEnterMazeServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.CheckEnterMaze;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterCheckEnterMazeServerMessage _) => new(Group, Command);

    #endregion Operators
}
