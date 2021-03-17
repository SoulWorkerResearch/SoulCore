using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.ChangeBackground)]
    public readonly struct CharacterChangeBackgroundRequest
    {
        public readonly int AccountId;
        public readonly uint BackgroundId;
        public readonly uint _1;

        public CharacterChangeBackgroundRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            BackgroundId = br.ReadUInt32();
            _1 = br.ReadUInt32();
        }
    }
}