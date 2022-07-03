using System;
using System.Reflection;
using Microsoft.Extensions.Hosting;
using NetDaemon.AppModel;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.Runtime;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemonApps.Infrastructure.DeviceTriggers;

#pragma warning disable CA1812

try
{
    await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonTextToSpeech()
        .UseNetDaemonMqttEntityManagement()
        .ConfigureServices((_, services) =>
         {
             services
              .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
              .AddNetDaemonStateManager()
              .AddNetDaemonScheduler();   
             services
             .AddSingleton<INotificationService, NotificationService>()
             .AddSingleton<IHassDeviceTriggers, HassDeviceTriggers>();
         })
        
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}