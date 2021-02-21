using SoulCore.Extensions;
using SoulCore.Types;
using SoulCore.IO.Network.Attributes;
using System.IO;

namespace SoulCore.IO.Network.Requests
{

    public sealed record ChatReceiveRequest
    {
        public ChatType Type { get; }
        public string Message { get; }

        public ChatReceiveRequest(BinaryReader br) => (Type, Message) = (br.ReadChatType(), br.ReadByteLengthUnicodeString());
    }
}
