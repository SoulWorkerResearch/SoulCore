using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterChangeMotionServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ChangeMotionReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterChangeMotionServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public short SubMotion { get; }

    #endregion Body

    #region Constructors

    internal CharacterChangeMotionServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        SubMotion = reader.ReadInt16();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
