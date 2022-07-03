using NetDaemon.Extensions.MqttEntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.VacuumApp;

//[Focus]
//[NetDaemonApp]
public class VacuumApp: IAsyncInitializable
{
    VacuumHandler handler;

    public VacuumApp(IHaContext haContext, IMqttEntityManager mqttEntityManager) 
    {
        var entities = new Entities(haContext);
        handler = new VacuumHandler(haContext, mqttEntityManager, entities.Vacuum.LivingRoomVacuum, entities.InputBoolean.Test1);
    }

    public Task InitializeAsync(CancellationToken cancellationToken)
    {
        return handler.InitializeAsync(cancellationToken);
    }
}
