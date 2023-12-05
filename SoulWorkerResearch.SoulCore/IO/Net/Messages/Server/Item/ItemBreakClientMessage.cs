using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemBreakClientMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Break;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemBreakClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public StorageType InvenType { get; } = reader.ReadStorageType();
    public ushort SlotPos { get; } = reader.ReadUInt16();
    public SerialEntity Serial { get; } = new SerialEntity(reader);
    public uint Count { get; } = reader.ReadUInt32();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
