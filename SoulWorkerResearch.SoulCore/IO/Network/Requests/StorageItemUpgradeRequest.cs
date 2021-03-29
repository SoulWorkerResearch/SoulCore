using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.Types;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct StorageItemUpgradeRequest
    {
        public StorageType StorageType { get; }
        public ushort Slot { get; }

        public StorageItemUpgradeRequest(BinaryReader br) => (StorageType, Slot) = (br.ReadStorageType(), br.ReadUInt16());
    }
}
