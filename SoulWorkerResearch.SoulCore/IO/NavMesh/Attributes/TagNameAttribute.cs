namespace SoulWorkerResearch.SoulCore.IO.NavMesh.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class TagAttribute : Attribute
{
    public string Name { get; }

    public TagAttribute(string name) => Name = name;
}
