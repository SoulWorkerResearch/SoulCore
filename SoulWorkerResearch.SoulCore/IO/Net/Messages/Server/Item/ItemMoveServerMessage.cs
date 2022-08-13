using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Item;

[ServerMessage(Group, Command)]
public readonly struct ItemMoveServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Item;
    public const ItemOpcode Command = ItemOpcode.Move;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ItemMoveServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public Entry Source { get; }
    public Entry Destination { get; }
    public uint Unknown1 { get; }
    public uint Unknown2 { get; }
    public uint Unknown3 { get; }

    #endregion Body

    #region Constructors

    internal ItemMoveServerMessage(BinaryReader reader)
    {
        Source = new(reader);
        Destination = new(reader);
        Unknown1 = reader.ReadUInt32();
        Unknown2 = reader.ReadUInt32();
        Unknown3 = reader.ReadUInt32();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region Types

    public readonly struct Entry
    {
        #region Body

        public StorageType Storage { get; }
        public int Item { get; }
        public ushort Slot { get; }

        #endregion Body

        #region Constructors

        internal Entry(BinaryReader reader)
        {
            Storage = reader.ReadStorageType();
            Item = reader.ReadInt32();
            Slot = reader.ReadUInt16();
        }

        #endregion Constructors        
    }

    #endregion Types
}
