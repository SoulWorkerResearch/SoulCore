using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.System;

[ClientMessage(Group, Command)]
public readonly record struct SystemServerOptisonUpdateClientMessage() : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.System;
    public const SystemOpcode Command = SystemOpcode.OptionUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(SystemServerOptisonUpdateClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IReadOnlyCollection<byte> Values { get; init; } = _emptyOptions;

    #endregion Body

    #region Constants

    private static readonly IReadOnlyCollection<byte> _emptyOptions = new byte[14];

    #endregion Constants

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        throw new NotImplementedException();
    }

    #endregion IBinaryConvertibleMessage
}
