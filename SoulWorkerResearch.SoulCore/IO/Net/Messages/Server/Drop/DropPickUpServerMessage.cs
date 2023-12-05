using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Drop;

[ServerMessage(Group, Command)]
public readonly struct DropPickUpServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Drop;
    public const DropOpcode Command = DropOpcode.PickUp;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(DropPickUpServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int ItemGroup { get; } = reader.ReadInt32();
    public long ItemSerial { get; } = reader.ReadInt64();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
