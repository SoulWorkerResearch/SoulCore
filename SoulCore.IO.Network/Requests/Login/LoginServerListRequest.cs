using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.ServerListReq)]
    public readonly struct LoginServerListRequest
    {
        public readonly int AccountId;

        public LoginServerListRequest(BinaryReader br) => AccountId = br.ReadInt32();
    }
}