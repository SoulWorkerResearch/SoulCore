using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading.Tasks;

using BatchFile = SoulWorkerResearch.SoulCore.IO.Batch.File;

namespace SoulWorkerResearch.SoulCore.Tests.IO.Batch;

[TestClass]
public sealed class EnumTest
{
    [TestMethod]
    public async Task MonsterSpawnTypeTest()
    {
        var files = Directory.GetFiles(Path.Combine(@"Datas", "World", "Table"), "*.vbatch");

        await Parallel.ForEachAsync(files, async (path, cancellationToken) =>
        {
            await using var fs = File.OpenRead(path);

            var root = BatchFile.FromStream(fs, cancellationToken);
        });
    }
}
