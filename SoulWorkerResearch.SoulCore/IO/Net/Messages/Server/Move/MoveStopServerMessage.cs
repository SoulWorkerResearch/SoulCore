using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using System.Numerics;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Server.Move;

[ServerMessage(Group, Command)]
public readonly struct MoveStopServerMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.Stop;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveStopServerMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int CharacterId { get; }
    public MapValue MapId { get; }
    public LocationValue Location { get; }
    public byte CheckCanMove { get; }

    #endregion Body

    #region Constructors

    internal MoveStopServerMessage(BinaryReader reader)
    {
        CharacterId = reader.ReadInt32();
        MapId = new(reader);
        Location = new(reader);
        CheckCanMove = reader.ReadByte();
    }

    #endregion Constructors

    #region Types

    public readonly struct LocationValue
    {
        #region Body

        public Vector3 Position { get; }
        public float Yaw { get; }
        public float Pitch { get; }

        #endregion Body

        #region Constructors

        public LocationValue(BinaryReader reader)
        {
            Position = reader.ReadVector3();
            Yaw = reader.ReadSingle();
            Pitch = reader.ReadSingle();
        }

        #endregion Constructors
    }

    #endregion Types
}
