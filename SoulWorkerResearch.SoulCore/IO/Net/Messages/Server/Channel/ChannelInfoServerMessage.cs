using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Channel;

/// <summary>
///     This packet no have content.
/// </summary>
[ServerMessage(Group, Command)]
public readonly struct ChannelInfoServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Channel;
    public const ChannelOpcode Command = ChannelOpcode.Info;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChannelInfoServerMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
