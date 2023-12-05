﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemCombineClientMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Combine;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemCombineClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public ItemPlace Source { get; } = new ItemPlace(reader);
    public ItemPlace Destination { get; } = new ItemPlace(reader);
    public ushort Count { get; } = reader.ReadUInt16();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}