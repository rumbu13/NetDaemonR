using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.CoverApp;

//[Focus]
[NetDaemonApp]


public class CoverApp
{

    readonly IList<CoverHandler> handlers = new List<CoverHandler>();

    public CoverApp(IHaContext haContext, IScheduler scheduler)
    {
        IEntities entities = new Entities(haContext);
        IServices services = new Services(haContext);

        handlers.Add(new CoverHandler(services, scheduler,
            entities.InputButton.OfficeCoverOpen,
            entities.InputButton.OfficeCoverClose,
            entities.InputButton.OfficeCoverStop,
            entities.InputButton.OfficeCoverReset,
            entities.InputSelect.OfficeCoverState,
            entities.InputNumber.OfficeCoverSlider,
            entities.InputNumber.OfficeCoverPercent,
            entities.InputNumber.OfficeCoverOpenDuration,
            entities.InputNumber.OfficeCoverCloseDuration,
            entities.InputText.OfficeCoverOpenCommand,
            entities.InputText.OfficeCoverCloseCommand));

        handlers.Add(new CoverHandler(services, scheduler,
            entities.InputButton.BedroomCoverDoorOpen,
            entities.InputButton.BedroomCoverDoorClose,
            entities.InputButton.BedroomCoverDoorStop,
            entities.InputButton.BedroomCoverDoorReset,
            entities.InputSelect.BedroomCoverDoorState,
            entities.InputNumber.BedroomCoverDoorSlider,
            entities.InputNumber.BedroomCoverDoorPercent,
            entities.InputNumber.BedroomCoverDoorOpenDuration,
            entities.InputNumber.BedroomCoverDoorCloseDuration,
            entities.InputText.BedroomCoverDoorOpenCommand,
            entities.InputText.BedroomCoverDoorCloseCommand));

        handlers.Add(new CoverHandler(services, scheduler,
            entities.InputButton.BedroomCoverWindowOpen,
            entities.InputButton.BedroomCoverWindowClose,
            entities.InputButton.BedroomCoverWindowStop,
            entities.InputButton.BedroomCoverWindowReset,
            entities.InputSelect.BedroomCoverWindowState,
            entities.InputNumber.BedroomCoverWindowSlider,
            entities.InputNumber.BedroomCoverWindowPercent,
            entities.InputNumber.BedroomCoverWindowOpenDuration,
            entities.InputNumber.BedroomCoverWindowCloseDuration,
            entities.InputText.BedroomCoverWindowOpenCommand,
            entities.InputText.BedroomCoverWindowCloseCommand));

        handlers.Add(new CoverHandler(services, scheduler,
            entities.InputButton.ChildRoomCoverOpen,
            entities.InputButton.ChildRoomCoverClose,
            entities.InputButton.ChildRoomCoverStop,
            entities.InputButton.ChildRoomCoverReset,
            entities.InputSelect.ChildRoomCoverState,
            entities.InputNumber.ChildRoomCoverSlider,
            entities.InputNumber.ChildRoomCoverPercent,
            entities.InputNumber.ChildRoomCoverOpenDuration,
            entities.InputNumber.ChildRoomCoverCloseDuration,
            entities.InputText.ChildRoomCoverOpenCommand,
            entities.InputText.ChildRoomCoverCloseCommand));
    }

  
}
