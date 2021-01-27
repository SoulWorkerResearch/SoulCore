using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    public readonly struct CharacterAchieveRewardRequest
    {
        public readonly int CharacterId;

        internal CharacterAchieveRewardRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
        }
    }
}