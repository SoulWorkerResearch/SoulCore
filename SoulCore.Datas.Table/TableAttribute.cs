using System;

namespace SoulCore.Data.Bin.Table
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class TableAttribute : Attribute
    {
        internal string Name { get; }

        internal TableAttribute(string name) =>
            Name = name;
    }
}