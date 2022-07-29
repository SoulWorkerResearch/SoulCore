using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterSelectServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.SelectReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterSelectServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public int AccountId { get; }
    public bool ClearTutorial { get; }
    public int PreviousMapId { get; }
    public int PreviousRevivePoint { get; }

    #endregion Body

    #region Constructors

    internal CharacterSelectServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        AccountId = reader.ReadInt32();
        ClearTutorial = reader.ReadBoolean();
        PreviousMapId = reader.ReadInt32();
        PreviousRevivePoint = reader.ReadInt32();
    }

    #endregion Constructors
}
