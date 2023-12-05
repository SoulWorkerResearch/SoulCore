using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.IO.Net.Attributes;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions;
using SoulWorkerResearch.SoulCore.IO.Net.Extensions.BinaryWriterExtensions;
using SoulWorkerResearch.SoulCore.IO.Net.Messages.Abstractions;
using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Messages.Client.Change;

[ClientMessage(Group, Command)]
public readonly record struct ChannelInfoClientMessage(ushort Map, IReadOnlyCollection<ChannelInfoClientMessage.Entry> Values) : IBinaryOutMessage
{
    #region Opcode

    public const GroupOpcode Group = GroupOpcode.Channel;
    public const ChannelOpcode Command = ChannelOpcode.Info;

    #endregion Opcode

    #region Operators

    public static implicit operator Opcode(ChannelInfoClientMessage _) => new(Group, Command);

    #endregion Operators

    #region IBinaryMessage

    public Opcode GetOpcode() => this;

    #endregion IBinaryMessage

    #region IBinaryConvertibleMessage

    public void ToBinary(BinaryWriter writer)
    {
        writer.Write(Map);
        writer.Write((byte)Values.Count);

        foreach (var entry in Values)
        {
            writer.Write(entry.Id);
            writer.Write(entry.Status);
        }
    }

    #endregion IBinaryConvertibleMessage

    #region DataTypes

    public readonly record struct Entry(ushort Id, ChannelLoadStatus Status);

    #endregion DataTypes
}
