global using BoosterKeyType = System.UInt16;
using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Res.Attributes;
using SoulWorkerResearch.SoulCore.Utils;

namespace SoulWorkerResearch.SoulCore.IO.Res.Entries;

[Table(TableName)]
public sealed class BoosterEntry : ITableEntry<BoosterKeyType>
{
    public const string TableName = "tb_Booster";

    public const byte EffectCount = 8;

    public sealed record Effect(BoosterEffectType EffectType, byte ApplyType, float EffectValue, ushort EffectString);

    public BoosterKeyType Id { get; }
    public ushort Group { get; }
    public IReadOnlyCollection<Effect> Effects { get; } = Array.Empty<Effect>();
    public string Info { get; } = string.Empty;
    public BoosterDecreaseTime DecreaseCondition { get; }
    public DateTime Time { get; }

    public BoosterEntry(BinaryReader reader)
    {
        Id = reader.ReadUInt16();
        Group = reader.ReadUInt16();
        Effects = ReadEffects(reader);
        Info = reader.ReadUTF8UnicodeString();
        DecreaseCondition = reader.ReadBoosterDecreaseTime();
        Time = Convert.ToDateTime(reader.ReadUInt32());
    }

    private static IReadOnlyCollection<Effect> ReadEffects(BinaryReader reader)
    {
        var effectTypes = reader.ReadBoosterEffectTypeAsEnumerable(EffectCount);
        var applyTypes = reader.ReadByteAsEnumerable(EffectCount);
        var effectValues = reader.ReadSingleAsArray(EffectCount);
        var effectStrings = reader.ReadUInt16AsEnumerable(EffectCount);

        return Iterable.Iterate(effectTypes, applyTypes, effectValues, effectStrings)
            .Select(value => new Effect(value.Item1, value.Item2, value.Item3, value.Item4))
            .ToArray();
    }
}
