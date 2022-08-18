using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginForSteamServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ForSteam;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginForSteamServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    private readonly byte[] _1;
    public string Mac { get; }
    public uint PacketVersion { get; }
    private readonly byte[] _2;
    public string SteamUserName { get; }
    private readonly ushort _3;
    public SteamId SteamId { get; }
    private readonly uint _4;
    private readonly byte[] _5;
    private readonly byte[] _6;
    public string ClientVersion { get; }
    public IReadOnlyList<Hash> Hashes { get; }
    private readonly uint[] _8;

    #endregion Body

    #region Constructors

    public LoginForSteamServerMessage(BinaryReader reader)
    {
        _1 = reader.ReadByteAsArray(3);
        Mac = reader.ReadUTF8UnicodeString();
        PacketVersion = reader.ReadUInt32();
        _2 = reader.ReadByteAsArray(7);
        SteamUserName = reader.ReadUTF8UnicodeString();
        _3 = reader.ReadUInt16();
        SteamId = new SteamId(reader);
        _4 = reader.ReadUInt32();
        _5 = reader.ReadByteAsArray(230);
        _6 = reader.ReadByteAsArray(790);
        ClientVersion = reader.ReadUTF8UnicodeString();
        Hashes = Enumerable.Repeat(0, 30).Select(_ => new Hash(reader)).ToArray();
        _8 = reader.ReadUInt32AsArray(3);
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region Types

    public readonly struct Hash
    {
        #region Properties

        public uint Id { get; }
        public string Value { get; }

        #endregion Properties

        #region Constructors

        public Hash(BinaryReader reader)
        {
            Id = reader.ReadUInt32();
            Value = reader.ReadUTF8UnicodeString();
        }

        #endregion Constructors
    }

    #endregion Types
}
