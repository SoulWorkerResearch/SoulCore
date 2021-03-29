using SoulWorkerResearch.SoulCore.IO.Network.Commands;
using System;

namespace SoulWorkerResearch.SoulCore.IO.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Enum)]
    public sealed class CategoryCommandAttribute : Attribute
    {
        public readonly CategoryCommand Category;

        internal CategoryCommandAttribute(CategoryCommand category) => Category = category;
    }
}
