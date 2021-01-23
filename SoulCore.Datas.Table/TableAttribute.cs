using System;

namespace SoulCore.Data.Bin.Table
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Name { get; }

        internal TableAttribute(string name) => Name = name;
    }
}