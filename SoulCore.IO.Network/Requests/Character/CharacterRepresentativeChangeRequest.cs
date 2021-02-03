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
        public readonly uint AccountId;
        public readonly uint CharacterId;
        public readonly Class Class;
        public readonly byte Level;
        public readonly string strName;
        public readonly uint ProfilePhotoID;
        public readonly long RepresentativeDate;
        public readonly int Error;

        internal CharacterRepresentativeChangeRequest(BinaryReader br)
        {
            AccountId = br.ReadUInt32();
            CharacterId = br.ReadUInt32();
            Class = br.ReadClass();
            Level = br.ReadByte();
            strName = br.ReadByteLengthUnicodeString();
            ProfilePhotoID = br.ReadUInt32();
            RepresentativeDate = br.ReadInt64();
            Error = br.ReadInt32();
        }
    }
}