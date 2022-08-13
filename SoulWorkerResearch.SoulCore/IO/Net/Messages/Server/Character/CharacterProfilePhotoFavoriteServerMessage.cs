using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterProfilePhotoFavoriteServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.ProfilePhotoFavorite;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterProfilePhotoFavoriteServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public bool IsFavorite { get; }

    #endregion Body

    #region Constructors

    internal CharacterProfilePhotoFavoriteServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        IsFavorite = reader.ReadBoolean();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
