using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly struct LoginContentsInfoClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.OptionLoad;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginContentsInfoClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; init; }
    public IReadOnlyCollection<byte> OptionBit { get; init; }
    public IReadOnlyCollection<bool> Content { get; init; }
    public IReadOnlyCollection<byte> KeyOption { get; init; }

    #endregion Body

    #region Constructors

    public LoginContentsInfoClientMessage()
    {
        AccountId = 0;
        OptionBit = OptionBitEmpty;
        Content = ContentEmpty;
        KeyOption = KeyOptionEmpty;
    }

    #endregion Constructors

    #region Constants

    private static readonly IReadOnlyCollection<byte> OptionBitEmpty = new byte[64];
    private static readonly IReadOnlyCollection<bool> ContentEmpty = new bool[14];
    private static readonly IReadOnlyCollection<byte> KeyOptionEmpty = new byte[2048];

    #endregion Constants

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(OptionBit);
        writer.Write(Content);
        writer.Write(AccountId);
        writer.Write(KeyOption);
    }

    #endregion IBinaryConvertibleMessage
}