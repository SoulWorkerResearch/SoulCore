using SoulCore.IO.Network.Exceptions;
using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Obsolete($"Use {nameof(LoginOptionUpdateRequest)} instead this")]
    public readonly struct LoginEnterWaitCancelRequest
    {
        internal LoginEnterWaitCancelRequest(BinaryReader _) => throw new IONetworkException($"Use {nameof(LoginOptionUpdateRequest)} instead this");
    }
}