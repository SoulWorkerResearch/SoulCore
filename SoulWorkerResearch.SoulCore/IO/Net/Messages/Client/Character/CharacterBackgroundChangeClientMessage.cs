using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly struct CharacterBackgroundChangeClientMessage(int Account, int Background, int _1 = 0) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ChangeBackground;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterBackgroundChangeClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Account);
        writer.Write(Background);
        writer.Write(_1);
    }

    #endregion IBinaryConvertibleMessage
}
