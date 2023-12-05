using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Party;

/// <summary>
///     This packet no have content.
/// </summary>
[ServerMessage(Group, Command)]
public readonly struct PartyUpdateInfoServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Party;
    public const PartyOpcode Command = PartyOpcode.UpdateInfo;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(PartyUpdateInfoServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal PartyUpdateInfoServerMessage(BinaryReader reader)
    {
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
