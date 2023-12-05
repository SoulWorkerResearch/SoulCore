using System.Text;
using SoulWorkerResearch.SoulCore.IO.NavMesh.DataType;

namespace SoulWorkerResearch.SoulCore.IO.NavMesh.Extensions;

internal static class BinaryReaderExtension
{
    internal static string ReadSerializedString(this BinaryReader reader) => Encoding.ASCII.GetString(reader.ReadBytes(reader.ReadByte() / 2));

    internal static SerializedType ReadSerializedType(this BinaryReader reader) => (SerializedType)reader.ReadByte();

    internal static VersionVariant ReadVersionVariant(this BinaryReader reader) => (VersionVariant)reader.ReadByte();
}
