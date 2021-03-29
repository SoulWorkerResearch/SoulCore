using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ListReq)]
    public readonly struct CharacterListRequest
    {
        public readonly long SessionKey;

        internal CharacterListRequest(BinaryReader br) => SessionKey = br.ReadInt64();
    }
}
