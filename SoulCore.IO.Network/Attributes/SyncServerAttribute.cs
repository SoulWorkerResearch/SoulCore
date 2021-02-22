using SoulCore.IO.Network.Types;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SyncServerAttribute : Attribute
    {
        internal readonly SyncServerType Type;
        internal readonly bool Register;

        public SyncServerAttribute(SyncServerType type = SyncServerType.None, bool register = false)
        {
            Type = type;
            Register = register;
        }
    }
}