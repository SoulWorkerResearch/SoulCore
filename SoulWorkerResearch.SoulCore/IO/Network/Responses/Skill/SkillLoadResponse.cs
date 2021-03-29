using System;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.Skill
{
    public sealed record SkillLoadResponse
    {
        public sealed record InfoInfo
        {
            public int Id { get; init; }
            public int Divergence { get; init; }
        }

        public sealed record DeckInfo
        {
            public ushort Pos { get; init; }
            public IEnumerable<int> SkillIds { get; init; } = Array.Empty<int>();
            public IEnumerable<int> UniSkillIds { get; init; } = Array.Empty<int>();
        }

        public int CharacterId { get; init; }
        public ushort TotalSkillPoint { get; init; }
        public ushort UsedSkillPoint { get; init; }
        public ushort DeckSlotCount { get; init; }
        public IEnumerable<InfoInfo> Info { get; init; } = Array.Empty<InfoInfo>();
        public IEnumerable<DeckInfo> Deck { get; init; } = Array.Empty<DeckInfo>();
    }
}
