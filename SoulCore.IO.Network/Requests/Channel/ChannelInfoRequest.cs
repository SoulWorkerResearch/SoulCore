using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Channel
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Channel, ChannelCommand.Info)]
    public readonly struct ChannelInfoRequest
    {
        internal ChannelInfoRequest(BinaryReader _)
        {
        }
    }
}