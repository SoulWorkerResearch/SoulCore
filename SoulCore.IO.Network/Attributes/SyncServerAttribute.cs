using SoulCore.IO.Network.Types;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SyncServerAttribute : Attribute
    {
        internal readonly SyncServerType Type;
        internal readonly Type Attribute;

        public SyncServerAttribute(SyncServerType type, Type attribute)
        {
            Type = type;
            Attribute = attribute;
        }
    }
}