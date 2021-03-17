using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.ServerConnectReq)]
    public readonly struct LoginServerConnectRequest
    {
        public readonly ushort WorldId;

        internal LoginServerConnectRequest(BinaryReader br) => WorldId = br.ReadUInt16();
    }
}