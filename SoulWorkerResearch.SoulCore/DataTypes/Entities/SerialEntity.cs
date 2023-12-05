namespace SoulWorkerResearch.SoulCore.DataTypes.Entities;

public readonly struct SerialEntity(BinaryReader reader)
{
    public long Seed { get => Value & 0xFFFFFFFF; }
    public long Minute { get => Value >> MIN_BITS & 0x3F; }
    public long Hour { get => Value >> HOUR_BITS & 0x1F; }
    public long Day { get => Value >> DAY_BITS & 0x1F; }
    public long Month { get => Value >> MONTH_BITS & 0xF; }
    public long Year { get => Value >> YEARS_BITS & 0xF; }
    public long Group { get => Value >> GROUPID_BITS & 0xF; }
    public long Server { get => Value >> SERVERID_BITS & 0xF; }

    internal readonly long Value = reader.ReadInt64();

    // private const int SEED_BITS = 32;
    private const int MIN_BITS = 6;
    private const int HOUR_BITS = 5;
    private const int DAY_BITS = 5;
    private const int MONTH_BITS = 4;
    private const int YEARS_BITS = 4;
    private const int GROUPID_BITS = 4;
    private const int SERVERID_BITS = 4;

    // result->xSerial = v5 & 0xF000000FFFFFFFFi64 | ((SystemTime.wMinute & 0x3F | ((SystemTime.wHour & 0x1F | (32 * (SystemTime.wDay & 0x1F | (32 * (SystemTime.wMonth & 0xF | (16 * (v4 | ((unsigned __int64)this->m_byServerID << 8)))))))) << 6)) << 32);
}
