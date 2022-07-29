using SoulWorkerResearch.SoulCore.IO.Net.Opcodes;

namespace SoulWorkerResearch.SoulCore.IO.Net.Attributes;

[AttributeUsage(AttributeTargets.Enum)]
public sealed class OpcodeGroupAttribute : Attribute
{
    public GroupOpcode Group { get; }

    public OpcodeGroupAttribute(GroupOpcode group) => Group = group;
}
