using SoulWorkerResearch.SoulCore.IO.NavMesh.DataType;
using SoulWorkerResearch.SoulCore.IO.NavMesh.Extensions;
using SoulWorkerResearch.SoulCore.IO.NavMesh.MetaInfo;
using System.Diagnostics;

namespace SoulWorkerResearch.SoulCore.IO.NavMesh;

//[Tag("hkReferencedObject")]
//public sealed record ReferencedObject
//{ }

//[Tag("hkRootLevelContainerNamedVariant")]
//public sealed record NamedVariant
//{
//    public string Name { get; init; }
//    public string ClassName { get; init; }
//    hkRefVariant m_variant;
//}

//[Tag("hkRootLevelContainer")]
//public sealed record RootLevelContainer
//{
//    [Tag("namedVariants")]
//    public List<NamedVariant> Variants { get; init; } = Enumerable.Empty<NamedVariant>().ToList();
//}

public sealed class BinarySerealizer
{
    #region Static Properties

    public static BinaryTagHeader Header { get; }
    public static string Version => "hk_2012.2.0-r1";

    #endregion Static Properties

    #region Static Methods

    public static void Deserealize<T>(Stream stream) where T : class
    {
        using var reader = new BinaryReader(stream);
        var header = new BinaryTagHeader(reader);

        var version = ReadVersion(reader);
        Debug.Assert(version == Version);

        for (int i = 0; i < 2; i++)
        {
            var valueType = reader.ReadSerializedType();
            switch (valueType)
            {
                case SerializedType.TopLevel:
                    var classInfo = new ClassMetaInfo(reader);
                    break;

                default:
                    throw new ApplicationException();
            }
        }
    }

    #endregion Static Methods

    #region Constructors

    public BinarySerealizer(Stream stream) { }

    #endregion Constructors

    #region Private Static Methods

    private static string ReadVersion(BinaryReader reader)
    {
        var type = reader.ReadSerializedType();
        if (type != SerializedType.Version) throw new ApplicationException();

        var versionType = reader.ReadVersionVariant();
        switch (versionType)
        {
            case VersionVariant._0:
                return string.Empty;

            case VersionVariant._1:
                break;

            case VersionVariant._2:
            case VersionVariant._3:
            case VersionVariant._4:
                return reader.ReadSerializedString();
        }

        throw new ApplicationException("Unrecognised tagfile version");
    }

    #endregion Private Static Methods
}
