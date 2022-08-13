using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Friend;

[ServerMessage(Group, Command)]
public readonly struct FriendRecruitListServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Friend;
    public const FriendOpcode Command = FriendOpcode.RecruitList;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(FriendRecruitListServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public byte LevelMin { get; }
    public byte LevelMax { get; }
    public Class Class { get; }

    #endregion Body

    #region Constructors

    internal FriendRecruitListServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        LevelMin = reader.ReadByte();
        LevelMax = reader.ReadByte();
        Class = reader.ReadClass();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
