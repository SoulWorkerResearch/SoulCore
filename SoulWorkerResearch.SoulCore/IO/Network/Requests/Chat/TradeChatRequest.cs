using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Trade)]
    public readonly struct TradeChatRequest
    {
        public readonly string Message;

        internal TradeChatRequest(BinaryReader br) => Message = br.ReadCharacterLengthUnicodeString();
    }
}
