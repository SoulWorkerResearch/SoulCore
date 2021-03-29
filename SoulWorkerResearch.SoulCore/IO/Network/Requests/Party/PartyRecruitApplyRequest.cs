using SoulWorkerResearch.SoulCore.Extensions;
using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using SoulWorkerResearch.SoulCore.IO.Network.Responses.Shared;
using SoulWorkerResearch.SoulCore.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    /// <summary>
    /// This packet no have content.
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
                Name = br.ReadCharacterLengthUnicodeString();
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
