using System.IO;

namespace SoulCore.IO.Network.Requests.Character
{
    /// <summary>
    /// This packet no have content.
    /// Use handler without packet.
    /// </summary>
    public readonly struct CharacterCheckEnterMazeRequest
    {
        internal CharacterCheckEnterMazeRequest(BinaryReader _)
        {
        }
    }
}
