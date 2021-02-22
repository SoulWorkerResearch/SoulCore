using System;
using System.IO;

namespace SoulCore.IO.Network.Requests.Login
{
    [Obsolete("Use LoginOptionUpdateRequest instead this", true)]
    public readonly struct LoginEnterWaitCancelRequest
    {
        internal LoginEnterWaitCancelRequest(BinaryReader _)
        {
        }
    }
}