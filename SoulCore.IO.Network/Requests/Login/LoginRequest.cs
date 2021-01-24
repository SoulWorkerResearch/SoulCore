using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Request]
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