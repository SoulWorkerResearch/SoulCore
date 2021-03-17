using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Friend
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Friend, FriendCommand.Load)]
    public readonly struct FriendLoadRequest
    {
        internal FriendLoadRequest(BinaryReader _)
        {
        }
    }
}