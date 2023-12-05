using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterEnterGameServerServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.EnterGameServerReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterEnterGameServerServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Account { get; }
    public int Character { get; }
    public MapValue Map { get; }
    public byte FirstConnect { get; }
    public ulong SessionKey { get; }

    #endregion Body

    #region Constructors

    internal CharacterEnterGameServerServerMessage(BinaryReader reader)
    {
        Account = reader.ReadInt32();
        Character = reader.ReadInt32();
        Map = new MapValue(reader);
        FirstConnect = reader.ReadByte();
        SessionKey = reader.ReadUInt64();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
