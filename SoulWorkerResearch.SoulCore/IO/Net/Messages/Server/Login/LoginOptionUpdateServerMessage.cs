using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginOptionUpdateServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.OptionUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginOptionUpdateServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IReadOnlyList<byte> Values { get; } = reader.ReadBytes(GameConfig.OptionsCount);

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
