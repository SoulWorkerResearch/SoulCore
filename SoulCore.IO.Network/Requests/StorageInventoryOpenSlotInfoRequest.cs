using SoulCore.Extensions;
using SoulCore.Types;
using SoulCore.IO.Network.Attributes;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct StorageInventoryOpenSlotInfoRequest
    {
        public IReadOnlyList<StorageType> Values { get; }

        public StorageInventoryOpenSlotInfoRequest(BinaryReader br) => Values = Enumerable.Repeat(0, br.ReadByte()).Select(_ => br.ReadStorageType()).ToArray();
    }
}
