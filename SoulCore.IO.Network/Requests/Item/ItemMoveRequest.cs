using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.Types;
using System.IO;

namespace SoulCore.IO.Network.Requests.Item
{
    [Request]
    public readonly struct ItemMoveRequest
    {
        public readonly struct ItemInfo
        {
            public StorageType Storage { get; }
            public int Item { get; }
            public ushort Slot { get; }

            public ItemInfo(BinaryReader br) => (Storage, Item, Slot) = (br.ReadStorageType(), br.ReadInt32(), br.ReadUInt16());
        }

        public ItemInfo Source { get; }
        public ItemInfo Destination { get; }
        public uint Unknown1 { get; }
        public uint Unknown2 { get; }
        public uint Unknown3 { get; }

        public ItemMoveRequest(BinaryReader br)
        {
            Source = new(br);
            Destination = new(br);
            Unknown1 = br.ReadUInt32();
            Unknown2 = br.ReadUInt32();
            Unknown3 = br.ReadUInt32();
        }
    }
}