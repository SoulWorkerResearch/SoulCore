using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.System;

[ServerMessage(Group, Command)]
public readonly struct SgTokenUpdateServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.System;
    public const SystemOpcode Command = SystemOpcode.SgTokenUpdate;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(SgTokenUpdateServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public string AccessToken { get; }
    public string RefreshToken { get; }
    public bool Renew { get; }

    #endregion Body

    #region Constructors

    internal SgTokenUpdateServerMessage(BinaryReader reader)
    {
        AccessToken = reader.ReadUTF16UnicodeString();
        RefreshToken = reader.ReadUTF16UnicodeString();
        Renew = reader.ReadBoolean();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
