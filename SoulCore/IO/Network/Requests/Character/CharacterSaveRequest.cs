using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Character, CharacterCommand.SaveReq)]
    public readonly struct CharacterSaveRequest
    {
        internal CharacterSaveRequest(BinaryReader _)
        {
        }
    }
}