using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulWorkerResearch.SoulCore.IO.NavMesh;

namespace SoulWorkerResearch.SoulCore.Tests.IO.NavMesh;

[TestClass]
public sealed class NavMeshTest
{
    [TestMethod]
    public async Task BinarySerealizerTest()
    {
        await using var stream = File.OpenRead(Path.Combine(@"Datas", "World", "Navmesh", "B03_BATTLECOURT.hkt"));
        var reader = new BinarySerealizer(stream);
    }
}
