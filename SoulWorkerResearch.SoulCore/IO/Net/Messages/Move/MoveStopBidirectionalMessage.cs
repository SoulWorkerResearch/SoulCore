using System.Numerics;
using SoulWorkerResearch.SoulCore.DataTypes.Entities;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Move;

[ClientMessage(Group, Command)]
[ServerMessage(Group, Command)]
public readonly struct MoveStopBidirectionalMessage : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Move;
    public const MoveOpcode Command = MoveOpcode.Stop;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(MoveStopBidirectionalMessage _) => new(Group, Command);

    #endregion Operators

    #region Body

    public int Character { get; }
    public MapEntity Map { get; }
    public LocationValue Location { get; }
    public byte CheckCanMove { get; }

    #endregion Body

    #region Constructors

    internal MoveStopBidirectionalMessage(BinaryReader reader)
    {
        Character = reader.ReadInt32();
        Map = new MapEntity(reader);
        Location = new LocationValue(reader);
        CheckCanMove = reader.ReadByte();
    }

    #endregion Constructors

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryOutcomingMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Character);
        writer.Write(Map);

        Location.ToBinary(writer);

        writer.Write(CheckCanMove);
    }

    #endregion IBinaryOutcomingMessage

    #region DataTypes

    public readonly struct LocationValue(BinaryReader reader) : IBinaryConvertibleMessage
    {
        #region Body

        public Vector3 Position { get; } = reader.ReadVector3();

        // X - Yaw
        // Y - Pitch
        public Vector2 Rotation { get; } = reader.ReadVector2();

        #endregion Body

        #region IBinaryOutcomingMessage

        public void ToBinary(BinaryWriter writer)
        {
            writer.Write(Position);
            writer.Write(Rotation);
        }

        #endregion IBinaryOutcomingMessage
    }

    #endregion DataTypes
}
