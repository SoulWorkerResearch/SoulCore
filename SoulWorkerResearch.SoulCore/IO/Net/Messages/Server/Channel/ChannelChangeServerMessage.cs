using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Channel;

[ServerMessage(Group, Command)]
public readonly struct ChannelChangeServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Channel;
    public const ChannelOpcode Command = ChannelOpcode.Change;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChannelChangeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ushort ChannelId { get; }

    #endregion Body

    #region Constructors

    internal ChannelChangeServerMessage(BinaryReader reader) => ChannelId = reader.ReadUInt16();

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}