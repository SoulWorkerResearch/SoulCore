using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Text;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly struct LoginResultClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.Result;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginResultClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; init; }
    public bool IsClearTutorial { get; init; }
    public string Mac { get; init; } = "00:00:00:00:00:00";
    public string ErrorMessage { get; init; } = string.Empty;
    public AuthLoginErrorMessageCode ErrorCode { get; init; }
    public byte LoginType { get; init; }
    public string AuthId { get; init; } = string.Empty;
    public ulong SessionKey { get; init; }
    public Permisson GameMaster { get; init; }
    public DateOnly Brith { get; init; }

    #endregion Body

    #region Constructors

    public LoginResultClientMessage()
    {
        AccountId = 0;
        IsClearTutorial = false;
        Mac = "00:00:00:00:00:00";
        ErrorMessage = string.Empty;
        ErrorCode = 0;
        LoginType = 0;
        AuthId = string.Empty;
        SessionKey = 0;
        GameMaster = 0;
        Brith = new DateOnly();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(AccountId);
        writer.Write(byte.MinValue);

        writer.Write(IsClearTutorial);
        writer.Write(Encoding.ASCII.GetBytes(Mac));

        writer.WriteUTF16UnicodeString(ErrorMessage);
        writer.Write(ErrorCode);

        writer.Write(byte.MinValue);
        writer.Write(LoginType);
        writer.Write(byte.MinValue);

        writer.WriteUTF16UnicodeString(AuthId);
        writer.Write(SessionKey);

        writer.Write(GameMaster);

        writer.Write((ushort)Brith.Year);
        writer.Write((byte)Brith.Month);
        writer.Write((byte)Brith.Day);

        writer.Write(uint.MinValue);
    }

    #endregion IBinaryConvertibleMessage
}
