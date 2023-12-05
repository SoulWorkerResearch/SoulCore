using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Channel;

[ServerMessage(Group, Command)]
public readonly struct ChannelChangeServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Channel;
    public const ChannelOpcode Command = ChannelOpcode.Change;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChannelChangeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ushort Channel { get; } = reader.ReadUInt16();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
