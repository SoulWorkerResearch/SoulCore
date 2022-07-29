using ICSharpCode.SharpZipLib.Zip;

namespace SoulWorkerResearch.SoulCore.IO;

public static class EncryptedZipFile
{
    public static ZipFile Create(string path, string? password = null, byte xor = 0x55)
    {
        byte[] buffer = File.ReadAllBytes(path);

        for (var q = 0; q != buffer.Length; ++q) buffer[q] ^= xor;

        var stream = new MemoryStream(buffer, false);

        return new ZipFile(stream, false)
        {
            Password = password
        };
    }
}
