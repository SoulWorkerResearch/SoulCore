using SoulWorkerResearch.SoulCore.Defines;
using SoulWorkerResearch.SoulCore.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.Net.DataTypes
{
    public readonly struct ItemPlace(BinaryReader reader)
    {
        public StorageType Storage { get; } = reader.ReadStorageType();
        public int Item { get; } = reader.ReadInt32();
        public ushort Slot { get; } = reader.ReadUInt16();
    }
}
