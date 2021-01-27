using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    public readonly partial struct CharacterUpdateTitleRequest
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
    }
}
