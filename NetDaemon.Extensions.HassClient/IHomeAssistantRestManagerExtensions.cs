using NetDaemon.Client;
using NetDaemon.Extensions.HassClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient;

public static class IHomeAssistantRestManagerExtensions
{

    #region Auth

    /// <summary>
    /// Gets a list of authentication providers
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassAuthProvider>?> GetAuthProviders(this IHomeAssistantRestManager connection,
        CancellationToken cancellationToken = default)

        => connection.GetRestCallAsync<IReadOnlyCollection<HassAuthProvider>>("auth/providers", cancellationToken);

    #endregion



}
