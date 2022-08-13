using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly struct CharacterListClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ListRes;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterListClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public IReadOnlyList<ICharacterValue> Values { get; init; }

    #endregion Body

    #region Constructors

    public CharacterListClientMessage() => Values = Array.Empty<ICharacterValue>();

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write((byte)Values.Count);

        foreach (var item in Values.Cast<IBinaryOutcomingMessage>())
        {
            item.ToBinary(writer);
        }
    }

    #endregion IBinaryOutcomingMessage
}
