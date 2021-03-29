using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Friend
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Friend, FriendCommand.RecruitInfo)]
    public readonly struct FriendRecruitInfoRequest
    {
        internal FriendRecruitInfoRequest(BinaryReader _)
        {
        }
    }
}
