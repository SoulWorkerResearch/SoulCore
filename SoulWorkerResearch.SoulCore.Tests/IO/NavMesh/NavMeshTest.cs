using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulWorkerResearch.SoulCore.IO.NavMesh;
using System.IO;
using System.Threading.Tasks;

namespace SoulWorkerResearch.SoulCore.Tests.IO.NavMesh;

[TestClass]
public sealed class NavMeshTest
{
    [TestMethod]
    public async Task BinarySerealizerTest()
    {
        await using var stream = File.OpenRead(@"Datas\World\Navmesh\B03_BATTLECOURT.hkt");
        var reader = new BinarySerealizer(stream);
    }
}
