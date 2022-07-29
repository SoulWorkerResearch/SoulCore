namespace SoulWorkerResearch.SoulCore.IO.NavMesh;

public readonly struct BinaryTagHeader
{
    public BinaryTagMagick Magick { get; init; }

    public BinaryTagHeader(BinaryReader reader) => Magick = new(reader);
}
