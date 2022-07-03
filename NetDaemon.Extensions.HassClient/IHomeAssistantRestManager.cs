namespace NetDaemon.Client;


/// <summary>
/// The only reason to exist for this interface is the fact that IHomeAssistantApiManager wrongly assumes
/// that all rest calls are using [hassurl]/api/path and does not expose Delete
/// IHomeAssistantRestManager gets, posts and deletes directly on [hassurl]/path/
/// </summary>
public interface IHomeAssistantRestManager
{

    Task<T?> GetRestCallAsync<T>(string restPath, CancellationToken cancellationToken);

    Task<T?> PostRestCallAsync<T>(string restPath, CancellationToken cancellationToken, object? data = null);

    Task<T?> DeleteRestCallAsync<T>(string restPath, CancellationToken cancellationToken);

}
