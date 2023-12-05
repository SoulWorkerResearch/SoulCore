using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterUpdateTitleServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.UpdateTitle;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterUpdateTitleServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public readonly struct Title
    {
        #region Body

        public uint Prefix { get; }
        public uint Suffix { get; }

        #endregion Body

        #region Constructors

        internal Title(BinaryReader reader)
        {
            Prefix = reader.ReadUInt32();
            Suffix = reader.ReadUInt32();
        }

        #endregion Constructors
    }

    public Title Battle { get; }
    public Title Preview { get; }

    #endregion Body

    #region Constructors

    internal CharacterUpdateTitleServerMessage(BinaryReader reader)
    {
        Battle = new Title(reader);
        Preview = new Title(reader);
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
