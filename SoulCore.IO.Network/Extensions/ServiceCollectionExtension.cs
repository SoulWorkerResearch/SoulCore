using Microsoft.Extensions.DependencyInjection;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SoulCore.IO.Network.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            foreach (Type type in GetSyncHandlers())
                services.AddTransient(type);

            return services.AddSingleton<HandlerProvider>();
        }

        private static IEnumerable<Type> GetSyncHandlers() => AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            .Where(type => type.IsDefined(typeof(HandlerAttribute)))
            .Select(t => t.DeclaringType!)
            .Distinct();
    }
}