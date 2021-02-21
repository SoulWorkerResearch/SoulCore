using SoulCore.IO.Network.Types;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ServiceTypeAttribute : Attribute
    {
        public readonly ServiceType Type;

        public ServiceTypeAttribute(ServiceType type = ServiceType.None) => Type = type;
    }
}