using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Party
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Party, PartyCommand.RecruitList)]
    public readonly struct PartyRecruitListRequest
    {
        internal PartyRecruitListRequest(BinaryReader _)
        {
        }
    }
}