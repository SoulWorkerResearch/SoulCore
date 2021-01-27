using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    public readonly struct CharacterProfilePhotoChangeRequest
    {
        public readonly int CharacterId;

        internal CharacterProfilePhotoChangeRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
        }
    }
}
