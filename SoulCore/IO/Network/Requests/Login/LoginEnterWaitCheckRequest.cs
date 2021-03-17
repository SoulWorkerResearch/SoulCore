using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
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