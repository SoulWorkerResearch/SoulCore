using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterSelectServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.SelectReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterSelectServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Character { get; }
    public int Account { get; }
    public bool ClearTutorial { get; }
    public int PreviousMap { get; }
    public int PreviousRevivePoint { get; }

    #endregion Body

    #region Constructors

    internal CharacterSelectServerMessage(BinaryReader reader)
    {
        Character = reader.ReadInt32();
        Account = reader.ReadInt32();
        ClearTutorial = reader.ReadBoolean();
        PreviousMap = reader.ReadInt32();
        PreviousRevivePoint = reader.ReadInt32();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
