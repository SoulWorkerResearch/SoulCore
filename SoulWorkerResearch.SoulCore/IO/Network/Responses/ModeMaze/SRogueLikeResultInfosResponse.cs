using System;
using System.Collections.Generic;

namespace SoulWorkerResearch.SoulCore.IO.Network.Responses.ModeMaze
{
    public sealed partial record SRogueLikeResultInfosResponse
    {
        public bool Clear { get; init; }
        public int RewardItem { get; init; }
        public int RewardCount { get; init; }
        public IEnumerable<Entity> Values { get; init; } = Array.Empty<Entity>();
    }
}
