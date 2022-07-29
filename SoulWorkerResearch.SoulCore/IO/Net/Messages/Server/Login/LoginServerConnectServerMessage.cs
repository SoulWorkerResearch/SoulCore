using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginServerConnectServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ServerConnectReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginServerConnectServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ushort GateId { get; }

    #endregion Body

    #region Constructors

    public LoginServerConnectServerMessage(BinaryReader reader) => GateId = reader.ReadUInt16();

    #endregion Constructors
}
