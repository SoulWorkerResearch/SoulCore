using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly struct CharacterRepresentativeChangeClientMessage : IBinaryOutcomingMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.RepresentativeChange;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterRepresentativeChangeClientMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; init; }
    public Entry Person { get; init; }
    public DateTime DateTime { get; init; }
    public int Result { get; init; }

    #endregion Body

    #region Types

    public readonly struct Entry
    {
        public static Entry Empty { get; } = new Entry();

        #region Body

        public int Id { get; init; }
        public Class Class { get; init; }
        public byte Level { get; init; }
        public string Name { get; init; }
        public uint PhotoId { get; init; }

        #endregion Body

        #region Constructors

        public Entry()
        {
            Id = 0;
            Class = Class.None;
            Level = 0;
            Name = string.Empty;
            PhotoId = 0;
        }

        #endregion Constructors
    }

    #endregion Types

    #region Constructors

    public CharacterRepresentativeChangeClientMessage()
    {
        AccountId = 0;
        Person = Entry.Empty;
        DateTime = DateTime.UtcNow;
        Result = 0;
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(AccountId);
        writer.Write(Person.Id);
        writer.Write(Person.Class);
        writer.Write(Person.Level);
        writer.WriteUTF16UnicodeString(Person.Name);
        writer.Write(Person.PhotoId);
        writer.Write(DateTime.Ticks);
        writer.Write(Result);
    }

    #endregion IBinaryOutcomingMessage
}
