using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Gesture;

[ServerMessage(Group, Command)]
public readonly record struct GestureShowClientMessage(int Person, int Gesture, GestureLocationValue Location) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Gesture;
    public const GestureOpcode Command = GestureOpcode.Show;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(GestureShowClientMessage _) =>  new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Person);
        writer.Write(Gesture);
        writer.Write(Location);
    }

    #endregion IBinaryConvertibleMessage
}
