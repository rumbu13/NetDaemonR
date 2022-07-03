using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Client;
using NetDaemon.Client.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHomeAssistantRestManager(this IServiceCollection services)
        {
            services.AddSingleton<HomeAssistantRestManager>();
            services.AddSingleton<IHomeAssistantRestManager>(s => s.GetRequiredService<HomeAssistantRestManager>());
            return services;
        }
    }
}
