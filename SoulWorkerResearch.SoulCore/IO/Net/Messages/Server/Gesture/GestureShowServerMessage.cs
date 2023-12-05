using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Gesture;

[ServerMessage(Group, Command)]
public readonly struct GestureShowServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Gesture;
    public const GestureOpcode Command = GestureOpcode.Show;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(GestureShowServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Gesture { get; } = reader.ReadInt32();
    public GestureLocationValue Location { get; } = new GestureLocationValue(reader);

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
