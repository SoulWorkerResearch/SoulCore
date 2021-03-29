using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.ServerConnectReq)]
    public readonly struct LoginServerConnectRequest
    {
        public readonly ushort WorldId;

        internal LoginServerConnectRequest(BinaryReader br) => WorldId = br.ReadUInt16();
    }
}
