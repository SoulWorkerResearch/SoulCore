using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.RecruitMyApplyList)]
    public readonly struct PartyRecruitMyApplyListRequest
    {
        internal PartyRecruitMyApplyListRequest(BinaryReader _)
        {
        }
    }
}
