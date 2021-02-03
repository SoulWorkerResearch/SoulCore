using System;
using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.InfoReq)]
    public readonly struct CharacterInfoRequest
    {
        public int CharacterId { get; }
        public byte Unknown1 { get; }

        internal CharacterInfoRequest(BinaryReader br)
        {
            CharacterId =br.ReadInt32();
             Unknown1 =br.ReadByte();
        }
    }
}
