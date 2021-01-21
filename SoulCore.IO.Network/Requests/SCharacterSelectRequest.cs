using System.IO;
using SoulCore.IO.Network.Attributes;

namespace SoulCore.IO.Network.Requests
{
    [Request]
    public readonly struct SCharacterSelectRequest
    {
        public int Id { get; }
        private byte[] Unknown { get; }

        public SCharacterSelectRequest(BinaryReader br)
        {
            Id = br.ReadInt32();
            Unknown = br.ReadBytes(13);
        }
    }
}
