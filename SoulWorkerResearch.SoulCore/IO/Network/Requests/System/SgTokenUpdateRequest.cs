using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.System
{
    [Request(CategoryCommand.System, SystemCommand.SgTokenUpdate)]
    public readonly struct SgTokenUpdateRequest
    {
        public readonly string AccessToken;
        public readonly string RefreshToken;
        public readonly bool Renew;

        internal SgTokenUpdateRequest(BinaryReader br)
        {
            AccessToken = br.ReadByteLengthUnicodeString();
            RefreshToken = br.ReadByteLengthUnicodeString();
            Renew = br.ReadBoolean();
        }
    }
}
