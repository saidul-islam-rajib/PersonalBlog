﻿using Mapster;
using MapsterMapper;
using System.Reflection;

namespace Sober.Api.Common.Mappings
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper> ();

            return services;
        }
    }
}
