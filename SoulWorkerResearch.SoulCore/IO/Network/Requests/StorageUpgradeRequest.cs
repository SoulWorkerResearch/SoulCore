using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.Types;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct StorageUpgradeRequest
    {
        public StorageType Storage { get; }

        public StorageUpgradeRequest(BinaryReader br) => Storage = br.ReadStorageType();
    }
}
