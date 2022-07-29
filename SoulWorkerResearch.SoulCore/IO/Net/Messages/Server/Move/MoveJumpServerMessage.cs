using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveJumpServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.Jump;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveJumpServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public IMapValue MapId { get; }
    public Vector3 Position { get; }
    public float Yaw { get; }
    public Vector2 TargetPosition { get; }
    public int JumpingMove { get; }
    public int JumpDrop { get; }
    public int BonusJump { get; }

    #endregion Body

    #region Constructors

    internal MoveJumpServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        MapId = new MapValue(reader);
        Position = reader.ReadVector3();
        Yaw = reader.ReadSingle();
        TargetPosition = reader.ReadVector2();
        JumpingMove = reader.ReadInt32();
        JumpDrop = reader.ReadInt32();
        BonusJump = reader.ReadInt32();
    }

    #endregion Constructors
}
