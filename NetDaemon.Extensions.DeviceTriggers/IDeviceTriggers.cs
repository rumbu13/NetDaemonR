using NetDaemon.AppModel;

namespace NetDaemon.Extensions.DeviceTriggers;

public interface IDeviceTriggers : IObservable<DeviceTrigger>, IAsyncDisposable, IAsyncInitializable
{

}
