using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

/// <summary>
///     This packet no have content.
/// </summary>
[ClientMessage(Group, Command)]
public readonly struct ItemBankInfoClientMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.BankInfo;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemBankInfoClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
