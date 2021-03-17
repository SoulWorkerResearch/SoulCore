using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.MatchingExit)]
    public readonly struct PartyMatchinExitRequest
    {
        internal PartyMatchinExitRequest(BinaryReader _)
        {
        }
    }
}