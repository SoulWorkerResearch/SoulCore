using SoulCore.IO.Network.Exceptions;
using System.Diagnostics;

namespace SoulCore.IO.Network.Utils
{
    public static class NetworkUtils
    {
        internal static void DropNetwork(string? message = null)
        {
            Debug.Fail(message);
            throw new NetworkException();
        }
    }
}