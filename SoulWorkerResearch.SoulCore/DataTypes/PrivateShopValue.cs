using SoulWorkerResearch.SoulCore.Abstractions.DataTypes;
using SoulWorkerResearch.SoulCore.Extensions;

namespace SoulWorkerResearch.SoulCore.DataTypes;

public readonly struct PrivateShopValue : IPrivateShopValue
{
    public static PrivateShopValue Empty { get; } = new();

    public byte Type { get; init; }
    public string Title { get; init; }

    internal PrivateShopValue(BinaryReader reader)
    {
        Type = reader.ReadByte();
        Title = reader.ReadUTF16UnicodeString();
    }
}
