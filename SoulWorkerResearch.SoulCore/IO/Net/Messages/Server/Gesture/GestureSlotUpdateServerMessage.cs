using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Gesture;

[ServerMessage(Group, Command)]
public readonly struct GestureSlotUpdateServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Gesture;
    public const GestureOpcode Command = GestureOpcode.SlotUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(GestureSlotUpdateServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IEnumerable<uint> GestureIds { get; }

    #endregion Body

    #region Constructors

    internal GestureSlotUpdateServerMessage(BinaryReader reader) => GestureIds = Enumerable
        .Range(0, Config.QuickSlotsCount)
        .Select(id => reader.ReadUInt32())
        .ToArray();

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
