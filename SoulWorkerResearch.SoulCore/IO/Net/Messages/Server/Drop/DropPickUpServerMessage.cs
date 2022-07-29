using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Drop;

[ServerMessage(Group, Command)]
public readonly struct DropPickUpServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Drop;
    public const DropOpcode Command = DropOpcode.PickUp;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(DropPickUpServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int ItemGroup { get; }
    public long ItemSerial { get; }

    #endregion Body

    #region Constructors

    internal DropPickUpServerMessage(BinaryReader reader)
    {
        ItemGroup = reader.ReadInt32();
        ItemSerial = reader.ReadInt64();
    }

    #endregion Constructors
}
