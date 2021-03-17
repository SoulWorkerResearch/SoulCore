using SoulCore.Extensions;
using System.IO;

namespace SoulCore.IO.Network.Responses.Chat
{
    public readonly struct ChatLeagueRequest
    {
        public readonly int CharacterId;
        public readonly int LeagueId;
        public readonly int MemberId;
        public readonly string Message;

        internal ChatLeagueRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            LeagueId = br.ReadInt32();
            MemberId = br.ReadInt32();
            Message = br.ReadCharacterLengthUnicodeString();
        }
    }
}