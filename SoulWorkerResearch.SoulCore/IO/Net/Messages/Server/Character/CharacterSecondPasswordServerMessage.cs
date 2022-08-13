using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterSecondPasswordServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.SecondPassword;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterSecondPasswordServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte CheckType { get; }
    public string Password { get; }

    #endregion Body

    #region Constructors

    internal CharacterSecondPasswordServerMessage(BinaryReader reader)
    {
        CheckType = reader.ReadByte();
        Password = reader.ReadUTF8UnicodeString();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
