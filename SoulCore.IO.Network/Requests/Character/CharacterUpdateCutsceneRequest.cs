using SoulCore.Extensions;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    public readonly struct CharacterUpdateCutsceneRequest
    {
        public readonly int CharacterId;
        public readonly bool OnPlay;
        public readonly string Name;

        internal CharacterUpdateCutsceneRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            OnPlay = br.ReadBoolean();
            Name = br.ReadNumberLengthUtf8String();
        }
    }
}