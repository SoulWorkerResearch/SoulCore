using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.System;

[ClientMessage(Group, Command)]
public readonly struct SystemServerOptisonUpdateClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.System;
    public const SystemOpcode Command = SystemOpcode.OptionUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(SystemServerOptisonUpdateClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IList<byte> Values { get; init; } = _emptyOptions;

    #endregion Body

    #region Constructors
    public SystemServerOptisonUpdateClientMessage() => Values = _emptyOptions;

    #endregion Constructors

    #region Constants

    private static readonly IList<byte> _emptyOptions = new byte[14];

    #endregion Constants

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
    }

    #endregion IBinaryOutcomingMessage
}
