using System;

namespace SoulCore.IO.Network.Exceptions
{
    public sealed class IONetworkException : Exception
    {
        public IONetworkException()
        {
        }

        public IONetworkException(string? message) : base(message)
        {
        }

        public IONetworkException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}