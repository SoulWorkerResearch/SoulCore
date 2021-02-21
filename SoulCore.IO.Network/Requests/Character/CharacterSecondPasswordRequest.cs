using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.SecondPassword)]
    public readonly struct CharacterSecondPasswordRequest
    {
        public readonly byte CheckType;
        public readonly string Password;

        internal CharacterSecondPasswordRequest(BinaryReader br)
        {
            CheckType = br.ReadByte();
            Password = br.ReadByteLengthUtf8String();
        }
    }
}