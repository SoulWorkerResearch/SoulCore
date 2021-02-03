using System.IO;
using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Requests
{

    public readonly struct DistrictConnectRequest
    {
        public int CharacterId { get; }
        private byte[] Unknown { get; }

        public DistrictConnectRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            Unknown = br.ReadBytes(13);
        }
    }
}
