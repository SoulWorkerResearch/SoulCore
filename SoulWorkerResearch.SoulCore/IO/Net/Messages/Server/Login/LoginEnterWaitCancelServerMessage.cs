using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginEnterWaitCancelServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.EnterWaitCancel;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginEnterWaitCancelServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IReadOnlyCollection<byte> Values { get; } = reader.ReadBytes(GameConfig.OptionsCount);

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
