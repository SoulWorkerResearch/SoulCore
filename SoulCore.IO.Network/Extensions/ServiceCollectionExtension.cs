using Microsoft.Extensions.DependencyInjection;
using SoulCore.IO.Network.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SoulCore.IO.Network.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddNetwork(this IServiceCollection services)
        {
            foreach (Type type in GetSyncHandlers())
            {
                services.AddTransient(type);
            }

            foreach (Type type in FilterByAttribute<SyncSessionAttribute>())
            {
                services.AddTransient(type);
            }

            foreach (Type type in FilterByAttribute<SyncServerAttribute>())
            {
                SyncServerAttribute? attribute = type.GetCustomAttribute<SyncServerAttribute>();
                if (attribute is null || !attribute.Register)
                {
                    continue;
                }

                services.AddSingleton(type);
            }

            return services;
        }

        private static IEnumerable<Type> FilterByAttribute<T>() where T : Attribute => AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => type.IsDefined(typeof(T)));

        private static IEnumerable<Type> GetSyncHandlers() => AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            .Where(type => type.IsDefined(typeof(SyncHandlerAttribute)))
            .Select(t => t.DeclaringType!)
            .Distinct();
    }
}