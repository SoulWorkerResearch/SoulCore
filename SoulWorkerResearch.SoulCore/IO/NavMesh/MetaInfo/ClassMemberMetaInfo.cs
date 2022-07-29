using SoulWorkerResearch.SoulCore.IO.NavMesh.Extensions;

namespace SoulWorkerResearch.SoulCore.IO.NavMesh.MetaInfo;

public readonly struct ClassMemberMetaInfo
{
    public string Name { get; } = string.Empty;
    public int Version { get; } = 0;
    public int _1 { get; } = 0;

    public ClassMemberMetaInfo(BinaryReader reader)
    {
        Name = reader.ReadSerializedString();
        Version = reader.ReadByte();
        // _1 = reader.ReadByte();
    }
}
