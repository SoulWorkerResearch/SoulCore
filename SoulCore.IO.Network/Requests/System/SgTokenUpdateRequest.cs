using SoulCore.Extensions;
using System.IO;

namespace SoulCore.IO.Network.Requests.System
{
    public readonly struct SgTokenUpdateRequest
    {
        public readonly string AccessToken;
        public readonly string RefreshToken;
        public readonly bool Renew;

        internal SgTokenUpdateRequest(BinaryReader br)
        {
            AccessToken = br.ReadNumberLengthUnicodeString();
            RefreshToken = br.ReadNumberLengthUnicodeString();
            Renew = br.ReadBoolean();
        }
    }
}