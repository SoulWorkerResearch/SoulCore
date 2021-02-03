using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.UpdateInfo)]
    public readonly struct PartyUpdateInfoRequest
    {
        internal PartyUpdateInfoRequest(BinaryReader _)
        {
        }
    }
}