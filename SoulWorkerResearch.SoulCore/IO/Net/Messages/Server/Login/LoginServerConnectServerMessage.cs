using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginServerConnectServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ServerConnectReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginServerConnectServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ushort Gate { get; } = reader.ReadUInt16();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
