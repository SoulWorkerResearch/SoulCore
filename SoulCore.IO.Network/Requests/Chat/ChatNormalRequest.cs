using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.Types;
using System.IO;

namespace SoulCore.IO.Network.Requests.Chat
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