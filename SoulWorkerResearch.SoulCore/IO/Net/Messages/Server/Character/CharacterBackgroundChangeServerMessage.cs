using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterBackgroundChangeServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ChangeBackground;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterBackgroundChangeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; }
    public int BackgroundId { get; }
    public int _1 { get; }

    #endregion Body

    #region Constructors

    public CharacterBackgroundChangeServerMessage(BinaryReader reader)
    {
        AccountId = reader.ReadInt32();
        BackgroundId = reader.ReadInt32();
        _1 = reader.ReadInt32();
    }

    #endregion Constructors
}