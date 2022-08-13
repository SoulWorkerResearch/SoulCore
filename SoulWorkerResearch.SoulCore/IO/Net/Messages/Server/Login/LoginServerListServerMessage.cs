using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginServerListServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ServerListReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginServerListServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; }

    #endregion Body

    #region Constructors

    public LoginServerListServerMessage(BinaryReader reader) => AccountId = reader.ReadInt32();

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}