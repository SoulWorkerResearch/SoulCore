using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.Types;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct StorageInventoryOpenSlotInfoRequest
    {
        public IReadOnlyList<StorageType> Values { get; }

        public StorageInventoryOpenSlotInfoRequest(BinaryReader br) => Values = Enumerable.Repeat(0, br.ReadByte()).Select(_ => br.ReadStorageType()).ToArray();
    }
}
