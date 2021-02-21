using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    [Request(CategoryCommand.Party, PartyCommand.RecruitAdd)]
    public readonly struct PartyRecruitAddRequest
    {
        public readonly uint PartyId;
        public readonly string Message;
        public readonly short MinLevel;
        public readonly short MaxLevel;
        public readonly byte Purpose;
        public readonly string MasterCharacterName;
        public readonly byte UserCount;
        public readonly int RemainTime;
        public readonly uint PurposeMapId;
        public readonly uint RecruitId;
        public readonly int MasterCharacaterId;
        public readonly byte PartyGroupType;

        internal PartyRecruitAddRequest(BinaryReader br)
        {
            PartyId = br.ReadUInt32();
            Message = br.ReadCharacterLengthUnicodeString();
            MinLevel = br.ReadInt16();
            MaxLevel = br.ReadInt16();
            Purpose = br.ReadByte();
            MasterCharacterName = br.ReadCharacterLengthUnicodeString();
            UserCount = br.ReadByte();
            RemainTime = br.ReadInt32();
            PurposeMapId = br.ReadUInt32();
            RecruitId = br.ReadUInt32();
            MasterCharacaterId = br.ReadInt32();
            PartyGroupType = br.ReadByte();
        }
    }
}