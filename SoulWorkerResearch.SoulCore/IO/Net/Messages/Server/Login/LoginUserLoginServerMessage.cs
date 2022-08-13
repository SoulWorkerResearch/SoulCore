using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginUserLoginServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.Req;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginUserLoginServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string Nickname { get; }
    public string Password { get; }
    public string Mac { get; }
    public int Version { get; }

    #endregion Body

    #region Constructors

    public LoginUserLoginServerMessage(BinaryReader reader)
    {
        Nickname = reader.ReadUTF8UnicodeString();
        Password = reader.ReadUTF8UnicodeString();
        Mac = reader.ReadUTF8UnicodeString();
        Version = reader.ReadInt32();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
