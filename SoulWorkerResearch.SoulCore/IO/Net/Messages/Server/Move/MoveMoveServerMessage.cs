using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveMoveServerMessage : IBinaryMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.Move;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveMoveServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public MapValue MapId { get; }
    public Vector3 Position { get; }
    public float Yaw { get; }
    public Vector2 TargetPosition { get; }
    public byte RunBit { get; }
    public float Pitch { get; }
    public float MoveSpeed { get; }
    public byte ChangeMotion { get; }
    public bool ShouldUpdatePos { get; }

    #endregion Body

    #region Constructors

    internal MoveMoveServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        MapId = new(reader);
        Position = reader.ReadVector3();
        Yaw = reader.ReadSingle();
        TargetPosition = reader.ReadVector2();
        RunBit = reader.ReadByte();
        Pitch = reader.ReadSingle();
        MoveSpeed = reader.ReadSingle();
        ChangeMotion = reader.ReadByte();
        ShouldUpdatePos = reader.ReadBoolean();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage
}
