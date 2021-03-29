using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Drop
{
    [Request(CategoryCommand.Drop, DropCommand.PickUp)]
    public readonly struct DropPickUpRequest
    {
        public readonly int Group;
        public readonly long Serial;

        internal DropPickUpRequest(BinaryReader br)
        {
            Group = br.ReadInt32();
            Serial = br.ReadInt64();
        }
    }
}
