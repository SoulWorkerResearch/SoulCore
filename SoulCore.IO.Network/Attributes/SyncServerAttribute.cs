using SoulCore.IO.Network.Types;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SyncServerAttribute : Attribute
    {
        public readonly SyncServerType Type;

        public SyncServerAttribute(SyncServerType type = SyncServerType.None) => Type = type;
    }
}