using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace SoulWorkerResearch.SoulCore.Vision
{
    public class ZipArchive : ZipFile
    {
        protected ZipArchive(string path, string? password = null, byte xor = 0x55) : base(GetFile(path, xor), false)
        {
            Password = password;
        }

        private static Stream GetFile(string path, byte xor)
        {
            byte[] data = File.ReadAllBytes(path);
            
            for (var q = 0; q != data.Length; ++q)
            {
                data[q] ^= xor;
            }

            return new MemoryStream(data);
        }
    }
}