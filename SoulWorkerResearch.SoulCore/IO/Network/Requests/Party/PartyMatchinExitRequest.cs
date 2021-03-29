using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Party
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
