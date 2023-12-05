using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly record struct CharacterRepresentativeChangeClientMessage(int Account, CharacterRepresentativeChangeClientMessage.Entry Person, int Result) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.RepresentativeChange;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterRepresentativeChangeClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public DateTime DateTime { get; init; } = DateTime.UtcNow;

    #endregion Body

    #region DataTypes

    public readonly record struct Entry(int Id, Defines.Character Class, byte Level, string Name, int Photo) { }

    #endregion DataTypes

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Account);
        writer.Write(Person.Id);
        writer.Write(Person.Class);
        writer.Write(Person.Level);
        writer.WriteUTF16UnicodeString(Person.Name);
        writer.Write(Person.Photo);
        writer.Write(DateTime.Ticks);
        writer.Write(Result);
    }

    #endregion IBinaryConvertibleMessage
}
