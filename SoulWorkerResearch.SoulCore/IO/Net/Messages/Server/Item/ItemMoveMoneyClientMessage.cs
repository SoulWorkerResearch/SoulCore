using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Reflection.PortableExecutable;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemMoveMoneyClientMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.MoveMoney;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemMoveMoneyClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public byte TargetType { get; } = reader.ReadByte();
    public ulong Money { get; } = reader.ReadUInt64();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
