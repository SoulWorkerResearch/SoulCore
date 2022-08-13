using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

/// <summary>
/// This packet no have content.
/// </summary>
[ServerMessage(Group, Command)]
public readonly struct LoginEnterWaitCheckServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.EnterWaitCheck;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginEnterWaitCheckServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Constructors

    internal LoginEnterWaitCheckServerMessage(BinaryReader reader)
    {
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
