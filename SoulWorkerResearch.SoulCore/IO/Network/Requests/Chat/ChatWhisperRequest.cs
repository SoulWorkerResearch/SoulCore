using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Chat
{
    [Request(CategoryCommand.Chat, ChatCommand.Whisper)]
    public readonly struct ChatWhisperRequest
    {
        public readonly string SenderCharacterName;
        public readonly string ReceiverCharacterName;
        public readonly string Message;
        public readonly int Result;
        public readonly int SenderCharacterId;

        internal ChatWhisperRequest(BinaryReader br)
        {
            SenderCharacterName = br.ReadCharacterLengthUnicodeString();
            ReceiverCharacterName = br.ReadCharacterLengthUnicodeString();
            Message = br.ReadCharacterLengthUnicodeString();
            Result = br.ReadInt32();
            SenderCharacterId = br.ReadInt32();
        }
    }
}
