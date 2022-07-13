using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NetDaemon.Extensions.DeviceTriggers;

public static class DependencyInjectionSetup
{
    public static IHostBuilder UseDeviceTriggers(this IHostBuilder builder)
        => builder.ConfigureServices((services) 
            => services.AddSingleton<IDeviceTriggers, Internal.DeviceTriggers>());
    
}
