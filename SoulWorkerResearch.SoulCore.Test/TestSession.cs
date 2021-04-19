using System;
using SoulWorkerResearch.SoulCore.IO.Network;

namespace SoulWorkerResearch.SoulCore.Test
{
    internal sealed class TestSession : BaseSession<TestServer, TestSession>
    {
        public TestSession(TestServer server, IServiceProvider provider) : base(server, provider)
        {
        }
    }
}