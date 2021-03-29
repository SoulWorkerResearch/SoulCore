using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.Types;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Item
{
    [Request(CategoryCommand.Item, ItemCommand.Move)]
    public readonly struct ItemMoveRequest
    {
        public readonly struct ItemInfo
        {
            public StorageType Storage { get; }
            public int Item { get; }
            public ushort Slot { get; }

            public ItemInfo(BinaryReader br)
            {
                Storage = br.ReadStorageType();
                Item = br.ReadInt32();
                Slot = br.ReadUInt16();
            }
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
