using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Network.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddNetwork(this IServiceCollection services)
        {
            foreach (Type type in GetByAttribute<IBaseSession>())
            {
                services.AddTransient(type);
            }

            foreach (Type type in GetByAttribute<IBaseServer>())
            {
                services.AddSingleton(type);
            }

            return services;
        }

        private static IEnumerable<Type> GetByAttribute<T>() => AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => type.IsAssignableTo(typeof(T)));
    }
}