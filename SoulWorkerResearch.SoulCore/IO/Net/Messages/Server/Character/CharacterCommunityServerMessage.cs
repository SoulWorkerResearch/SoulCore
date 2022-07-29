using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterCommunityServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.Community;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterCommunityServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal CharacterCommunityServerMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors
}
