using System;

namespace SoulCore.IO.Datas.Bin.Table
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class TableAttribute : Attribute
    {
        public readonly string Name;

        internal TableAttribute(string name) => Name = name;
    }
}