using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.Types;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.EnterServerReq)]
    public readonly struct LoginEnterServerRequest
    {
        public readonly int AccountId;
        public readonly ushort LastWorldId;
        public readonly ulong SessionKey;
        public readonly EnterGateWay Way;

        internal LoginEnterServerRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            LastWorldId = br.ReadUInt16();
            SessionKey = br.ReadUInt64();
            Way = br.ReadEnterGateWayType();
        }
    }
}
