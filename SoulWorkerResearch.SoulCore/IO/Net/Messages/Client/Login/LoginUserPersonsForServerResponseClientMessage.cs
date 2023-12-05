using System.Diagnostics;
using System.Net;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly record struct LoginUserPersonsForServerResponseClientMessage(byte LastSelectedId, IReadOnlyCollection<LoginUserPersonsForServerResponseClientMessage.Entry> Values) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ServerList;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginUserPersonsForServerResponseClientMessage _) => new(Group, Command);

    #endregion Operators

    #region DataTypes

    public readonly record struct Entry(ushort Id, string Name, GateStatus Status, IPEndPoint Endpoint, int Online, byte Person);

    #endregion DataTypes

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        Debug.Assert(Values.Count < byte.MaxValue);

        writer.Write(LastSelectedId);
        writer.Write((byte)Values.Count);

        foreach (var gate in Values)
        {
            writer.Write(gate.Id);
            writer.Write(gate.Endpoint.Port);
            writer.WriteUTF8UnicodeString(gate.Name);
            writer.WriteUTF8UnicodeString(gate.Endpoint.ToString());
            writer.Write(gate.Status);
            writer.Write(gate.Online);
            writer.Write(gate.Person);
        }
    }

    #endregion IBinaryConvertibleMessage
}
