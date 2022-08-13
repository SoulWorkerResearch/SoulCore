using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Net;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly struct LoginEnterServerClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.EnterServer;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginEnterServerClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public DnsEndPoint Endpoint { get; init; }

    #endregion Body

    #region Constructors

    public LoginEnterServerClientMessage() => Endpoint = new DnsEndPoint(string.Empty, 0);

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Endpoint);
    }

    #endregion IBinaryConvertibleMessage
}
