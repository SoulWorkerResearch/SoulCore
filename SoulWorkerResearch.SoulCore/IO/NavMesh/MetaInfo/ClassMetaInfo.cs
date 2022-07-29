using SoulWorkerResearch.SoulCore.IO.NavMesh.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.NavMesh.MetaInfo;

public readonly struct ClassMetaInfo
{
    public string Name { get; } = string.Empty;
    public int Version { get; } = 0;
    public string Parent { get; } = string.Empty;
    public IReadOnlyList<ClassMemberMetaInfo> Members { get; } = Array.Empty<ClassMemberMetaInfo>();

    public ClassMetaInfo(BinaryReader reader)
    {
        Name = reader.ReadSerializedString();
        Version = reader.ReadByte();

        var parent = reader.ReadByte();
        int members = reader.ReadByte();

        Members = Enumerable
            .Range(0, members)
            .Select(_ => new ClassMemberMetaInfo(reader))
            .ToArray();
    }
}
