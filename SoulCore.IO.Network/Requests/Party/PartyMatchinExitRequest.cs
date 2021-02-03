using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses.Shared;
using SoulCore.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulCore.IO.Network.Requests.Party
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.MatchingExit)]
    public readonly struct PartyMatchinExitRequest
    {
        internal PartyMatchinExitRequest(BinaryReader _)
        {
        }
    }

    [Request(CategoryCommand.Party, PartyCommand.MatchingCheck)]
    public readonly struct PartyMatchinCheckRequest
    {
        internal PartyMatchinCheckRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.RecruitList)]
    public readonly struct PartyRecruitListRequest
    {
        internal PartyRecruitListRequest(BinaryReader _)
        {
        }
    }

    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.RecruitMyApplyList)]
    public readonly struct PartyRecruitMyApplyListRequest
    {
        internal PartyRecruitMyApplyListRequest(BinaryReader _)
        {
        }
    }

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
            Message = br.ReadByteLengthUnicodeString();
            MinLevel = br.ReadInt16();
            MaxLevel = br.ReadInt16();
            Purpose = br.ReadByte();
            MasterCharacterName = br.ReadByteLengthUnicodeString();
            UserCount = br.ReadByte();
            RemainTime = br.ReadInt32();
            PurposeMapId = br.ReadUInt32();
            RecruitId = br.ReadUInt32();
            MasterCharacaterId = br.ReadInt32();
            PartyGroupType = br.ReadByte();
        }
    }

    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.RecruitApply)]
    public readonly struct PartyRecruitApplyRequest
    {
        public readonly struct PartyMember
        {
            public readonly int MemberId;
            public readonly string Name;
            public readonly byte byLevel;
            public readonly Class byClass;
            public readonly ClassAdvancement Advancement;
            public readonly uint ProfilePhotoId;
            public readonly int LocationId;
            public readonly int Channel;
            public readonly int MaxHp;
            public readonly int Hp;
            public readonly bool Login;
            public readonly MapIdPacketSharedStructure MapId;

            internal PartyMember(BinaryReader br)
            {
                MemberId = br.ReadInt32();
                Name = br.ReadByteLengthUnicodeString();
                byLevel = br.ReadByte();
                byClass = br.ReadClass();
                Advancement = br.ReadClassAdvancement();
                ProfilePhotoId = br.ReadUInt32();
                LocationId = br.ReadInt32();
                Channel = br.ReadInt32();
                MaxHp = br.ReadInt32();
                Hp = br.ReadInt32();
                Login = br.ReadBoolean();
                MapId = new(br);
            }
        };

        public readonly int Result;
        public readonly int CharacterId;
        public readonly uint RecruitId;
        public readonly int MasterCharacterId;
        public readonly byte PartyGroupType;
        public readonly IEnumerable<PartyMember> Members;

        internal PartyRecruitApplyRequest(BinaryReader br)
        {
            Result = br.ReadInt32();
            CharacterId = br.ReadInt32();
            RecruitId = br.ReadUInt32();
            MasterCharacterId = br.ReadInt32();
            PartyGroupType = br.ReadByte();

            byte count = br.ReadByte();
            Members = Enumerable.Repeat(0, count).Select(_ => new PartyMember(br)).ToArray();
        }
    }
}