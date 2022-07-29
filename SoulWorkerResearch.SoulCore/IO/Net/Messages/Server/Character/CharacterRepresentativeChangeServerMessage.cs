using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterRepresentativeChangeServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.RepresentativeChange;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterRepresentativeChangeServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; }
    public Entry Person { get; }
    public DateTime DateTime { get; }
    public int Result { get; }

    #endregion Body

    #region Constructors

    public CharacterRepresentativeChangeServerMessage(BinaryReader reader)
    {
        AccountId = reader.ReadInt32();
        Person = new(reader);
        DateTime = new DateTime(reader.ReadInt64());
        Result = reader.ReadInt32();
    }

    #endregion Constructors

    #region Types

    public readonly struct Entry
    {
        public int Id { get; }
        public Class Class { get; }
        public byte Level { get; }
        public string Name { get; }
        public int PhotoId { get; }

        public Entry(BinaryReader reader)
        {
            Id = reader.ReadInt32();
            Class = reader.ReadClass();
            Level = reader.ReadByte();
            Name = reader.ReadUTF16UnicodeString();
            PhotoId = reader.ReadInt32();
        }
    }

    #endregion Types
}