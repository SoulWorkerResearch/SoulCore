using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterListServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ListReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterListServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public long SessionKey { get; }

    #endregion Body

    #region Constructors

    internal CharacterListServerMessage(BinaryReader reader)
    {
        SessionKey = reader.ReadInt64();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
