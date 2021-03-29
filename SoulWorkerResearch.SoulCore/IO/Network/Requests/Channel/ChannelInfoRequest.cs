using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Channel
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Channel, ChannelCommand.Info)]
    public readonly struct ChannelInfoRequest
    {
        internal ChannelInfoRequest(BinaryReader _)
        {
        }
    }
}
