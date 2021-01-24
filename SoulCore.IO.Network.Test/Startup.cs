using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace ow.Framework.Tests
{
    public class Startup
    {
        public ServiceProvider ServiceProvider { get; }

        public Startup() => ServiceProvider = new ServiceCollection()
            .AddSingleton(GetConfiguration())
            .BuildServiceProvider();

        private static IConfiguration GetConfiguration() => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("config/appsettings.json", false, true)
            .Build();
    }
}