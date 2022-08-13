using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly struct CharacterBackgroundChangeClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ChangeBackground;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterBackgroundChangeClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; init; }
    public int BackgroundId { get; init; }
    public int _1 { get; init; }

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(AccountId);
        writer.Write(BackgroundId);
        writer.Write(_1);
    }

    #endregion IBinaryOutcomingMessage
}
