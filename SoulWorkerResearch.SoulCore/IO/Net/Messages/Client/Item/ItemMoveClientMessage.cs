using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Item;

[ClientMessage(Group, Command)]
public readonly struct ItemMoveClientMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Move;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemMoveClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public InfoValue Info { get; init; }
    public TickcountValue Tickcount { get; init; }

    #endregion Body

    #region Constructors

    internal ItemMoveClientMessage(BinaryReader reader)
    {
        Info = new(reader);
        Tickcount = new(reader);
    }

    #endregion Constructors

    #region Types

    public readonly struct InfoValue
    {
        #region Body

        public byte SrcInvenType { get; init; }
        public int SrcItemId { get; init; }
        public ushort SrcSlotPos { get; init; }
        public byte DestInvenType { get; init; }
        public int DestItemId { get; init; }
        public ushort DestSlotPos { get; init; }

        #endregion Body

        #region Constructors

        internal InfoValue(BinaryReader reader)
        {

            SrcInvenType = reader.ReadByte();
            SrcItemId = reader.ReadInt32();
            SrcSlotPos = reader.ReadUInt16();
            DestInvenType = reader.ReadByte();
            DestItemId = reader.ReadInt32();
            DestSlotPos = reader.ReadUInt16();
        }

        #endregion Constructors
    }

    public readonly struct TickcountValue
    {
        #region Body

        public uint Ticknum { get; init; }
        public ulong Tickcount { get; init; }

        #endregion Body

        #region Constructors

        public TickcountValue(BinaryReader reader)
        {
            Ticknum = reader.ReadUInt32();
            Tickcount = reader.ReadUInt64();
        }

        #endregion Constructors
    }

    #endregion Types
}