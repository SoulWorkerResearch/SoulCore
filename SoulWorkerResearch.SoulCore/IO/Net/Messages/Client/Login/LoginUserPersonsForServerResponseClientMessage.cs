using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Diagnostics;
using System.Net;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Login;

[ClientMessage(Group, Command)]
public readonly struct LoginUserPersonsForServerResponseClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Login;
    public const LoginOpcode Command = LoginOpcode.ServerList;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(LoginUserPersonsForServerResponseClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte LastSelectedId { get; init; }
    public IReadOnlyCollection<Entry> Values { get; init; }

    #endregion Body

    #region Types

    public readonly struct Entry
    {
        public ushort Id { get; init; }
        public string Name { get; init; }
        public GateStatus Status { get; init; }
        public DnsEndPoint Endpoint { get; init; }
        public uint PlayersCount { get; init; }
        public byte PersonsCount { get; init; }

        public Entry()
        {
            Id = 0;
            Name = string.Empty;
            Status = 0;
            Endpoint = new DnsEndPoint(string.Empty, 0);
            PlayersCount = 0;
            PersonsCount = 0;
        }
    }

    #endregion Types

    #region Constructors

    public LoginUserPersonsForServerResponseClientMessage()
    {
        LastSelectedId = 0;
        Values = Array.Empty<Entry>();
    }

    #endregion Constructors

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
            writer.Write(gate.PlayersCount);
            writer.Write(gate.PersonsCount);
        }
    }

    #endregion IBinaryConvertibleMessage
}
