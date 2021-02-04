using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Friend, FriendCommand.RecruitAdd)]
    public readonly struct FriendRecruitAddRequest
    {
        internal FriendRecruitAddRequest(BinaryReader _)
        {
        }
    }
}