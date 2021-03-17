using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.AchieveReward)]
    public readonly struct CharacterAchieveRewardRequest
    {
        public readonly int CharacterId;

        internal CharacterAchieveRewardRequest(BinaryReader br) => CharacterId = br.ReadInt32();
    }
}