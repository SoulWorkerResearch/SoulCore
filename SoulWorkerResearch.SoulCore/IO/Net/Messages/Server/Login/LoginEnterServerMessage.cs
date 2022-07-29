using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Login;

[ServerMessage(Group, Command)]
public readonly struct LoginEnterServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.EnterServerReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginEnterServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; }
    public ushort LastWorldId { get; }
    public ulong SessionKey { get; }
    public EnterGateWay Way { get; }

    #endregion Body

    #region Constructors

    public LoginEnterServerMessage(BinaryReader reader)
    {
        AccountId = reader.ReadInt32();
        LastWorldId = reader.ReadUInt16();
        SessionKey = reader.ReadUInt64();
        Way = reader.ReadEnterGateWayType();
    }

    #endregion Constructors
}
