using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.UpdateTitle)]
    public readonly struct CharacterUpdateTitleRequest
    {
        public readonly struct Title
        {
            public readonly uint Prefix;
            public readonly uint Suffix;

            internal Title(BinaryReader br)
            {
                Prefix = br.ReadUInt32();
                Suffix = br.ReadUInt32();
            }
        }

        public readonly Title Battle;
        public readonly Title Preview;

        internal CharacterUpdateTitleRequest(BinaryReader br)
        {
            Battle = new(br);
            Preview = new(br);
        }
    }
}