using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Login
{
    [Request(CategoryCommand.Login, LoginCommand.Req)]
    public readonly struct LoginUserLoginRequest
    {
        public readonly string Nickname;
        public readonly string Password;
        public readonly string Mac;
        public readonly int Version;

        internal LoginUserLoginRequest(BinaryReader br)
        {
            Nickname = br.ReadByteLengthUnicodeString();
            Password = br.ReadByteLengthUnicodeString();
            Mac = br.ReadByteLengthUnicodeString();
            Version = br.ReadInt32();
        }
    }
}
