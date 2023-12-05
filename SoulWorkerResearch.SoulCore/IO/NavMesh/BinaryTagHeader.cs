namespace SoulWorkerResearch.SoulCore.IO.NavMesh;

public readonly struct BinaryTagHeader(BinaryReader reader)
{
    public BinaryTagMagic Magic { get; } = new BinaryTagMagic(reader);
}
