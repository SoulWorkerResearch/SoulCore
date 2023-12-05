using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;
using SoulWorkerResearch.SoulCore.DataTypes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Character;

[ClientMessage(Group, Command)]
public readonly record struct CharacterEnterMapClientMessage(MapValue Map, EnterMapValue EnterMap, int Result) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Character;
    public const CharacterOpcode Command = CharacterOpcode.SelectRes;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(CharacterEnterMapClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Map);
        writer.Write(EnterMap);
        // writer.Write(Result); ??? TODO: research it
    }

    #endregion IBinaryConvertibleMessage
}
