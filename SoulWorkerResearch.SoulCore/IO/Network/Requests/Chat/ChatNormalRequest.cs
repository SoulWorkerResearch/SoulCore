using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.Types;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Normal)]
    public readonly struct ChatNormalRequest
    {
        public readonly ChatType ChatType;
        public readonly string Message;

        internal ChatNormalRequest(BinaryReader br)
        {
            ChatType = br.ReadChatType();
            Message = br.ReadCharacterLengthUnicodeString();
        }
    }
}
