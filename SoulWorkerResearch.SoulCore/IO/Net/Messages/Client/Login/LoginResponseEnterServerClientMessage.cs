using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly struct LoginResponseEnterServerClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.EnterServerRes;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginResponseEnterServerClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public GateEnterResult Result { get; init; }
    public int AccountId { get; init; }

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Result);
        writer.Write(AccountId);
    }

    #endregion IBinaryConvertibleMessage
}
