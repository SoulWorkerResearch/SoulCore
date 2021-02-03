using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.Req)]
    public readonly struct LoginRequest
    {
        public string Nickname { get; }
        public string Password { get; }
        public string Mac { get; }
        public uint Version { get; }

        public LoginRequest(BinaryReader br)
        {
            Nickname = br.ReadNumberLengthUnicodeString();
            Password = br.ReadNumberLengthUnicodeString();
            Mac = br.ReadNumberLengthUnicodeString();
            Version = br.ReadUInt32();
        }
    }
}