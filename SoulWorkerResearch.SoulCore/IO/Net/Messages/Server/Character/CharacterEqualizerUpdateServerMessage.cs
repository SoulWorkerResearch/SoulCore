﻿using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterEqualizerUpdateServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.EqualizerUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterEqualizerUpdateServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    #endregion Body

    #region Constructors

    internal CharacterEqualizerUpdateServerMessage(BinaryReader reader)
    {
        throw new NotImplementedException();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
