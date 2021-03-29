using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests.Login
{
    /// <summary>
    /// This packet no have content.
    /// </summary>
    [Request(CategoryCommand.Login, LoginCommand.EnterWaitCancel)]
    public readonly struct LoginEnterWaitCheckRequest
    {
        internal LoginEnterWaitCheckRequest(BinaryReader _)
        {
        }
    }
}
