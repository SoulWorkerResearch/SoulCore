using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginForStoveGamesServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ForSg;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginForStoveGamesServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string AuthCode { get; } = reader.ReadUTF8UnicodeString();
    public string Account { get; } = reader.ReadUTF8UnicodeString();
    public string MacAddress { get; } = reader.ReadUTF8UnicodeString();
    public int PacketVersion { get; } = reader.ReadInt32();
    public int Ip { get; } = reader.ReadInt32();
    public long Member { get; } = reader.ReadInt64();
    public AuthType AuthType { get; } = reader.ReadAuthType();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
