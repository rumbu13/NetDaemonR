using NetDaemon.Extensions.MqttEntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.VacuumApp
{

    public record RoomInfo(DateTime LastClean, double Dirty, bool IsCleaning, bool HasError, SensorEntity? sensorDebris, NumberEntity? numberFrequency);


    

    public class VacuumHandler : AvailableEnabledHandler, IAsyncInitializable
    {

        VacuumEntity vacuum;
        IHaContext haContext;
        IMqttEntityManager mqttEntityManager;

        SensorEntity sensorBinFill;

        readonly Dictionary<string, RoomInfo> rooms = new()
        {
            { "living_room", new RoomInfo(DateTime.MinValue, 0, false, false, null, null) },
            { "kitchen", new RoomInfo( DateTime.MinValue, 0, false, false, null, null) },
            { "entry_hall", new RoomInfo(DateTime.MinValue, 0, false, false, null, null) },
            { "bathroom", new RoomInfo(DateTime.MinValue, 0, false, false, null, null) },
        };

        public VacuumHandler(IHaContext haContext, IMqttEntityManager mqttEntityManager, VacuumEntity vacuum, InputBooleanEntity enabled)
            : base(vacuum, enabled)
        {
            this.haContext = haContext;
            this.mqttEntityManager = mqttEntityManager;
            this.vacuum = vacuum;
           
        }

        void AddRoom(string name, string id)
        {
          
        }

        async Task SetupAsync()
        {
            string id = vacuum.EntityId.Substring(vacuum.EntityId.IndexOf('.') + 1);

            string sensorBinFillId = $"sensor.{id}_bin_fill";

            sensorBinFill = await mqttEntityManager.RequiresSensorAsync(haContext, sensorBinFillId,
                new EntityCreationOptions()
                {
                    Persist = false,
                    Name = vacuum.Attributes?.FriendlyName + " Bin Fill"
                },
                new MqttSensorAttributes()
                {
                    Icon = "mdi:trash-can-outline",      
                    UnitOfMeasurement = "%",                    
                }) ;

            foreach (var room in rooms)
            {
                string sensorDebrisId = $"sensor.{room.Key}_cleaning_debris";

                var sensorDebris = await mqttEntityManager.RequiresSensorAsync(haContext, sensorDebrisId,
                    new EntityCreationOptions()
                    {
                        Persist = false,
                    },
                    new MqttSensorAttributes()
                    {
                        Icon = "mdi:broom",
                        UnitOfMeasurement = "%",
                });

                string sensorFrequencyId = $"number.{room.Key}_cleaning_frequency_days";

                var sensorFrequency = await mqttEntityManager.RequiresNumberAsync(haContext, sensorFrequencyId,
                    new EntityCreationOptions()
                    {
                        Persist = false,
                    },
                    new MqttNumberAttributes()
                    {
                        Icon = "mdi:calendar",
                        Min = 1,
                        Max = 30,
                        Step = 1,

                    });

            }
        }

        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            await SetupAsync();
            
        }


    }
}
