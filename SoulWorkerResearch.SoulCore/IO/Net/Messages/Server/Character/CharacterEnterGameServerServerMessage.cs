using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Character;

[ServerMessage(Group, Command)]
public readonly struct CharacterEnterGameServerServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.EnterGameServerReq;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterEnterGameServerServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int AccountId { get; }
    public int CharacterId { get; }
    public IMapValue MapId { get; }
    public byte FirstConnect { get; }
    public ulong SessionKey { get; }

    #endregion Body

    #region Constructors

    internal CharacterEnterGameServerServerMessage(BinaryReader reader)
    {
        AccountId = reader.ReadInt32();
        CharacterId = reader.ReadInt32();
        MapId = new MapValue(reader);
        FirstConnect = reader.ReadByte();
        SessionKey = reader.ReadUInt64();
    }

    #endregion Constructors
}
