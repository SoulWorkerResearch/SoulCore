namespace SoulWorkerResearch.SoulCore.IO.NavMesh.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class TagAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
