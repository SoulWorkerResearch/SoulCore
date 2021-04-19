using Microsoft.Extensions.DependencyInjection;
using SoulWorkerResearch.SoulCore.IO.Network;

namespace SoulWorkerResearch.SoulCore.Test
{
    internal sealed class TestServer : BaseServer<TestServer, TestSession>
    {
        public TestServer() : base(new ServiceCollection().BuildServiceProvider(), "", 0)
        {
        }
    }
}