global using ChattingCommandKeyType = System.UInt32;

using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed record ChattingCommandEntry : ITableEntry<ChattingCommandKeyType>
{
    public const string TableName = "tb_ChattingCommand";

    private const byte CommandCount = 5;

    public ChattingCommandKeyType Id { get; }
    public byte PermissionLevel { get; }
    public IReadOnlyList<string> Command { get; }
    public uint ActionType { get; }

    public ChattingCommandEntry(BinaryReader br)
    {
        Id = br.ReadUInt16();
        PermissionLevel = br.ReadByte();
        Command = br.ReadByteLengthUnicodeStringAsArray(CommandCount);
        ActionType = br.ReadUInt32();
    }
}
