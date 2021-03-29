using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.Chat
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
