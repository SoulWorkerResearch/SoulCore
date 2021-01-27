using System.IO;

namespace SoulCore.IO.Network.Requests.Channel
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    public readonly struct ChannelInfoRequest
    {
        internal ChannelInfoRequest(BinaryReader _)
        {
        }
    }
}