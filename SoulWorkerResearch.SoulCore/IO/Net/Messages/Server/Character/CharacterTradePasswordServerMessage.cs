using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Diagnostics;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterTradePasswordServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.TradePassword;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterTradePasswordServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public PasswordCheckType CheckType { get; }
    public byte[] Password { get; }

    #endregion Body

    #region Constructors

    internal CharacterTradePasswordServerMessage(BinaryReader reader)
    {
        CheckType = (PasswordCheckType)reader.ReadByte();
        Debug.Assert(Enum.IsDefined(typeof(PasswordCheckType), CheckType));

        Password = reader.ReadBytes(5);
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
