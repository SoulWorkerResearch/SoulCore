using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.Req)]
    public readonly struct LoginRequest
    {
        public readonly string Nickname;
        public readonly string Password;
        public readonly string Mac;
        public readonly int Version;

        public LoginRequest(BinaryReader br)
        {
            Nickname = br.ReadByteLengthUnicodeString();
            Password = br.ReadByteLengthUnicodeString();
            Mac = br.ReadByteLengthUnicodeString();
            Version = br.ReadInt32();
        }
    }
}