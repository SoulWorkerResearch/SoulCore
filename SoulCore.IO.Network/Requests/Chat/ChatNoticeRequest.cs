using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Notice)]
    public readonly struct ChatNoticeRequest
    {
        public readonly byte Type;
        public readonly string Message;
        public readonly string Color;
        public readonly int MessageCode;

        internal ChatNoticeRequest(BinaryReader br)
        {
            Type = br.ReadByte();
            Message = br.ReadCharacterLengthUnicodeString();
            Color = br.ReadByteLengthUtf8String();
            MessageCode = br.ReadInt32();
        }
    }
}