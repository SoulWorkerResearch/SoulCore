using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Character, CharacterCommand.LoadTitle)]
    public readonly struct CharacterLoadTitleRequest
    {
        internal CharacterLoadTitleRequest(BinaryReader _)
        {
        }
    }
}
