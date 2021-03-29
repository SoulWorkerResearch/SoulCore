using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.Types;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct StorageItemUseRequest
    {
        public StorageType Storage { get; }
        public ushort Slot { get; }
        public uint Seed { get; }
        public int Item { get; }
        public byte Count { get; }

        public StorageItemUseRequest(BinaryReader br)
        {
            Storage = br.ReadStorageType();
            Slot = br.ReadUInt16();
            Seed = br.ReadUInt32();
            Item = br.ReadInt32();
            Count = br.ReadByte();
        }
    }
}
