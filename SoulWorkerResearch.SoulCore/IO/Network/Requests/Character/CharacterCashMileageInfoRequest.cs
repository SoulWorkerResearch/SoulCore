using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Character
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Character, CharacterCommand.CashMileageInfo)]
    public readonly struct CharacterCashMileageInfoRequest
    {
        internal CharacterCashMileageInfoRequest(BinaryReader _)
        {
        }
    }
}
