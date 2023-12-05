using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginEnterServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.EnterServerReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginEnterServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Account { get; } = reader.ReadInt32();
    public ushort LastGate { get; } = reader.ReadUInt16();
    public long Key { get; } = reader.ReadInt64();
    public EnterGateWay Way { get; } = reader.ReadEnterGateWayType();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
