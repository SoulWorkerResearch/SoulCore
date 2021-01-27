using SoulCore.IO.Network.Commands;
using System;

namespace SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Enum)]
    public sealed class CategoryCommandAttribute : Attribute
    {
        public CategoryCommand Category { get; }

        public CategoryCommandAttribute(CategoryCommand category)
        {
            Category = category;
        }
    }
}