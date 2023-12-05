using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginForSteamServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ForSteam;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginForSteamServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    private readonly byte[] _1 = reader.ReadByteAsArray(3);
    public string Mac { get; } = reader.ReadUTF8UnicodeString();
    public uint PacketVersion { get; } = reader.ReadUInt32();
    private readonly byte[] _2 = reader.ReadByteAsArray(7);
    public string SteamUserName { get; } = reader.ReadUTF8UnicodeString();
    private readonly ushort _3 = reader.ReadUInt16();
    public SteamEntity SteamId { get; } = new SteamEntity(reader);
    private readonly uint _4 = reader.ReadUInt32();
    private readonly byte[] _5 = reader.ReadByteAsArray(230);
    private readonly byte[] _6 = reader.ReadByteAsArray(790);
    public string ClientVersion { get; } = reader.ReadUTF8UnicodeString();
    public IReadOnlyList<HashValue> Hashes { get; } = Enumerable.Repeat(0, 30).Select(_ => new HashValue(reader)).ToArray();
    private readonly uint[] _8 = reader.ReadUInt32AsArray(3);

    #endregion Body
    #region Constructors

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region DataTypes

    public readonly struct HashValue(BinaryReader reader)
    {
        public uint Id { get; } = reader.ReadUInt32();
        public string Value { get; } = reader.ReadUTF8UnicodeString();
    }

    #endregion DataTypes
}
