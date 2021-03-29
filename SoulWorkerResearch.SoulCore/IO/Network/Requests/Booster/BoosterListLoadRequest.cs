using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Booster
{
    [Request(CategoryCommand.Booster, BoosterCommand.ListLoad)]
    public readonly struct BoosterListLoadRequest
    {
        internal BoosterListLoadRequest(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
