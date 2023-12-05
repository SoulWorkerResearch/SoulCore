using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly record struct CharacterListClientMessage(IReadOnlyList<CharacterValue> Values) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ListRes;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterListClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write((byte)Values.Count);

        foreach (var item in Values.Cast<IBinaryConvertibleMessage>())
        {
            item.ToBinary(writer);
        }
    }

    #endregion IBinaryConvertibleMessage
}
