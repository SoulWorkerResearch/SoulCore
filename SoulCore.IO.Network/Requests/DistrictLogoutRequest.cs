using SoulCore.Extensions;
using SoulCore.Types;
using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct DistrictLogoutRequest
    {
        public int Character { get; }
        public int Account { get; }
        public DistrictLogOutWay Way { get; }

        public DistrictLogoutRequest(BinaryReader br) => (Character, Account, Way) = (br.ReadInt32(), br.ReadInt32(), br.ReadLogoutWayType());
    }
}