using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
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
