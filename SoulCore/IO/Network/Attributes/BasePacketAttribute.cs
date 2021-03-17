using SoulCore.IO.Network.Commands;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = true)]
    public abstract class BasePacketAttribute : Attribute
    {
        public readonly CategoryCommand Category;
        public readonly byte Command;

        protected BasePacketAttribute(CategoryCommand category, byte command) => (Category, Command) = (category, command);
    }
}