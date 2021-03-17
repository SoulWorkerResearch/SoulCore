using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Responses.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Whisper)]
    public readonly struct ChatForceRequest
    {
        public readonly int CharacterId;
        public readonly int ForceId;
        public readonly string Message;

        internal ChatForceRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            ForceId = br.ReadInt32();
            Message = br.ReadCharacterLengthUnicodeString();
        }
    }
}