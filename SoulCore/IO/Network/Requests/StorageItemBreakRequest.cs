using SoulCore.Extensions;
using SoulCore.Types;
using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{

    public readonly struct StorageItemBreakRequest
    {
        public StorageType StorageType { get; }
        public ushort Slot { get; }

        public StorageItemBreakRequest(BinaryReader br) => (StorageType, Slot) = (br.ReadStorageType(), br.ReadUInt16());
    }
}
