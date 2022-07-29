namespace SoulWorkerResearch.SoulCore.IO.Res.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public sealed class TableAttribute : Attribute
{
    public string Name { get; }

    public TableAttribute(string name) => Name = name;
}
