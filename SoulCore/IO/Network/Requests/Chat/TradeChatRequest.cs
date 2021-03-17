using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Trade)]
    public readonly struct TradeChatRequest
    {
        public readonly string Message;

        internal TradeChatRequest(BinaryReader br) => Message = br.ReadCharacterLengthUnicodeString();
    }
}