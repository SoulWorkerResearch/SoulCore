using SoulCore.Extensions;
using SoulCore.Types;
using System.IO;

namespace SoulCore.IO.Network.Requests
{
    public readonly struct LoginEnterServerRequest
    {
        public readonly int AccountId;
        public readonly ushort GateId;
        public readonly ulong SessionKey;
        public readonly EnterGateWay Way;

        public LoginEnterServerRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            GateId = br.ReadUInt16();
            SessionKey = br.ReadUInt64();
            Way = br.ReadEnterGateWayType();
        }
    }
}