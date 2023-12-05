using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Gesture;

[ServerMessage(Group, Command)]
public readonly struct GestureSlotUpdateBidirectionalMessage : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Gesture;
    public const GestureOpcode Command = GestureOpcode.SlotUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(GestureSlotUpdateBidirectionalMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IEnumerable<int> Values { get; init; }

    #endregion Body

    #region Constructors

    internal GestureSlotUpdateBidirectionalMessage(BinaryReader reader) => Values = Enumerable
        .Range(0, GameConfig.QuickSlotsCount)
        .Select(id => reader.ReadInt32())
        .ToArray();

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write((byte)Values.Count());
        writer.Write(Values);
    }

    #endregion IBinaryOutcomingMessage
}
