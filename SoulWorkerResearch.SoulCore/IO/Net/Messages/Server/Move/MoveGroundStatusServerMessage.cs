using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveGroundStatusServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.GroundStatus;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveGroundStatusServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public int OnGround { get; }
    public float PosZ { get; }

    #endregion Body

    #region Constructors

    internal MoveGroundStatusServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        OnGround = reader.ReadInt32();
        PosZ = reader.ReadSingle();
    }

    #endregion Constructors
}
