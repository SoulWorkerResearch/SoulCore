using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoulWorkerResearch.SoulCore.Korean.Test
{
    public sealed class Startup
    {
        public readonly ServiceProvider ServiceProvider;

        public Startup() => ServiceProvider = new ServiceCollection()
            .AddSingleton(GetConfiguration())
            .BuildServiceProvider();

        private static IConfiguration GetConfiguration() => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("config/appsettings.json")
            .Build();
    }
}