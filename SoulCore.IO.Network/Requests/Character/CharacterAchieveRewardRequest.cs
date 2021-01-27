using System.IO;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.AchieveReward)]
    public readonly struct CharacterAchieveRewardRequest
    {
        public readonly int CharacterId;

        internal CharacterAchieveRewardRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
        }
    }
}
