using SoulCore.Extensions;
using SoulCore.Types;
using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{

    public readonly struct StorageUpgradeRequest
    {
        public StorageType Storage { get; }

        public StorageUpgradeRequest(BinaryReader br) => Storage = br.ReadStorageType();
    }
}
