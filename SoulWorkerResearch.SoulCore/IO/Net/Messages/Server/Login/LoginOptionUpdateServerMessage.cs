using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginOptionUpdateServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.OptionUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginOptionUpdateServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IReadOnlyList<byte> Values { get; }

    #endregion Body

    #region Constructors

    public LoginOptionUpdateServerMessage(BinaryReader reader) => Values = reader.ReadBytes(Config.OptionsCount);

    #endregion Constructors
}
