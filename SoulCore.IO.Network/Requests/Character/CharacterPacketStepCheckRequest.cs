using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    public readonly struct CharacterPacketStepCheckRequest
    {
        public readonly int CharacterId;

        internal CharacterPacketStepCheckRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
        }
    }
}
