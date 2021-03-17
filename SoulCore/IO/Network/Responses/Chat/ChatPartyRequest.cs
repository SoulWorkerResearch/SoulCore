using SoulCore.Extensions;
using System.IO;

namespace SoulCore.IO.Network.Responses.Chat
{
    public readonly struct ChatPartyRequest
    {
        public readonly int CharacterId;
        public readonly int PartyId;
        public readonly string Message;

        internal ChatPartyRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            PartyId = br.ReadInt32();
            Message = br.ReadCharacterLengthUnicodeString();
        }
    }
}