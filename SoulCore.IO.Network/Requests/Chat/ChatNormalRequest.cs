using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Normal)]
    public readonly struct ChatNormalRequest
    {
        public readonly byte ChatType;
        public readonly string Message;

        internal ChatNormalRequest(BinaryReader br)
        {
            ChatType = br.ReadByte();
            Message = br.ReadCharacterLengthUnicodeString();
        }
    }
}