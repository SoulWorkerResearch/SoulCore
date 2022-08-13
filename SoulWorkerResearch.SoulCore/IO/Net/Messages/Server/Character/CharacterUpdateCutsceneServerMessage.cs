using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterUpdateCutsceneServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.UpdateCutscene;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterUpdateCutsceneServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public bool OnPlay { get; }
    public string Name { get; }

    #endregion Body

    #region Constructors

    internal CharacterUpdateCutsceneServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        OnPlay = reader.ReadBoolean();
        Name = reader.ReadUTF8UnicodeString();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
