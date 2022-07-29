using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginForStoveGamesServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ForSg;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginForStoveGamesServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string AuthCode { get; }
    public string AccountId { get; }
    public string MacAddress { get; }
    public int PacketVersion { get; }
    public int Ip { get; }
    public long Member { get; }
    public AuthType AuthType { get; }

    #endregion Body

    #region Constructors

    public LoginForStoveGamesServerMessage(BinaryReader reader)
    {
        AuthCode = reader.ReadUTF8UnicodeString();
        AccountId = reader.ReadUTF8UnicodeString();
        MacAddress = reader.ReadUTF8UnicodeString();
        PacketVersion = reader.ReadInt32();
        Ip = reader.ReadInt32();
        Member = reader.ReadInt64();
        AuthType = reader.ReadAuthType();
    }

    #endregion Constructors
}
