using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginUserLoginServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.Req;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginUserLoginServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string Nickname { get; } = reader.ReadUTF8UnicodeString();
    public string Password { get; } = reader.ReadUTF8UnicodeString();
    public string Mac { get; } = reader.ReadUTF8UnicodeString();
    public int Version { get; } = reader.ReadInt32();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
