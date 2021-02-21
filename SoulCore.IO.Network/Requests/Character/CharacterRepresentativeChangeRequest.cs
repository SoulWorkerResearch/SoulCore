using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.Types;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    [Request(CategoryCommand.Character, CharacterCommand.RepresentativeChange)]
    public readonly struct CharacterRepresentativeChangeRequest
    {
        public readonly int AccountId;
        public readonly int CharacterId;
        public readonly Class Class;
        public readonly byte Level;
        public readonly string strName;
        public readonly uint ProfilePhotoId;
        public readonly long RepresentativeDate;
        public readonly int Error;

        internal CharacterRepresentativeChangeRequest(BinaryReader br)
        {
            AccountId = br.ReadInt32();
            CharacterId = br.ReadInt32();
            Class = br.ReadClass();
            Level = br.ReadByte();
            strName = br.ReadCharacterLengthUnicodeString();
            ProfilePhotoId = br.ReadUInt32();
            RepresentativeDate = br.ReadInt64();
            Error = br.ReadInt32();
        }
    }
}