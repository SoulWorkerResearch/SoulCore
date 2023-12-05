using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly record struct LoginContentsInfoClientMessage(int Account) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.OptionLoad;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginContentsInfoClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IReadOnlyCollection<byte> OptionBit { get; init; } = OptionBitEmpty;
    public IReadOnlyCollection<bool> Content { get; init; } = ContentEmpty;
    public IReadOnlyCollection<byte> KeyOption { get; init; } = KeyOptionEmpty;

    #endregion Body

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
        writer.Write(Account);
        writer.Write(KeyOption);
    }

    #endregion IBinaryConvertibleMessage
}
