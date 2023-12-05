using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Server;

public readonly record struct ServerEnterMap(MapValue Map, EnterMapValue EnterMap) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Server;
    public const ServerOpcode Command = ServerOpcode.EnterMap;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ServerEnterMap _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Map);
        writer.Write(EnterMap);
    }

    #endregion IBinaryConvertibleMessage
}
