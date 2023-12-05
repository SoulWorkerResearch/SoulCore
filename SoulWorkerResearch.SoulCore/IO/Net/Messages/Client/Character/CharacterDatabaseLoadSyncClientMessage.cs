using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

/// <summary>
///     This packet no have content.
/// </summary>
[ClientMessage(Group, Command)]
public readonly struct CharacterDatabaseLoadSyncClientMessage : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.DbLoadSync;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterDatabaseLoadSyncClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer) {}

    #endregion IBinaryConvertibleMessage
}
