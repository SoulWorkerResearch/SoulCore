using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendRecruitListServerMessage(BinaryReader reader) : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.RecruitList;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendRecruitListServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; } = reader.ReadInt32();
    public byte LevelMin { get; } = reader.ReadByte();
    public byte LevelMax { get; } = reader.ReadByte();
    public Defines.Character Class { get; } = reader.ReadClass();

    #endregion Body

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
