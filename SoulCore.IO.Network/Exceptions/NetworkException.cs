using System;

namespace SoulCore.IO.Network.Exceptions
{
    public sealed class NetworkException : Exception
    {
        public NetworkException()
        {
        }

        public NetworkException(string? message) : base(message)
        {
        }

        public NetworkException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}