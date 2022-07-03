using NetDaemon.Client;
using NetDaemon.Client.HomeAssistant.Extensions;
using NetDaemon.Extensions.HassClient.Internal.Commands;
using System.Threading.Tasks;
using NetDaemon.Extensions.HassClient.Models;
using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemon.Extensions.HassClient;

public static class IHomeAssistantConnectionExtensions
{
    #region Alexa

    /// <summary>
    /// Gets a list of Alexa entities
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassAlexaEntity>?> GetAlexaEntitiesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassAlexaList, IReadOnlyCollection<HassAlexaEntity>>(
            new HassAlexaList(), cancellationToken);

    /// <summary>
    /// Synchronizes Alexa entities with the cloud
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task SyncAlexaEntitiesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassAlexaSync, Object>(
            new HassAlexaSync(), cancellationToken);

    #endregion

    #region Area

    /// <summary>
    /// Gets a list of areas
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<Models.HassArea>?> GetAreasAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassAreaList, IReadOnlyCollection<Models.HassArea>>(
            new HassAreaList(), cancellationToken);


    /// <summary>
    /// Creates a new area
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name">Area name</param>
    /// <param name="picture">Associated picture</param>
    /// <param name="cancellationToken"></param>
    /// <returns>The newly created area</returns>
    public static Task<Models.HassArea?> CreateAreaAsync(this IHomeAssistantConnection connection, string name, 
        string? picture = default, CancellationToken cancellationToken = default) 
    
        => connection.SendCommandAndReturnResponseAsync<HassAreaCreate, Models.HassArea>(
            new HassAreaCreate(name, picture), cancellationToken);
    
    /// <summary>
    /// Deletes the specified area
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>always null</returns>
    public static Task DeleteAreaAsync(this IHomeAssistantConnection connection, string id, 
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassAreaDelete, Object>(
            new HassAreaDelete(id), cancellationToken);
    

    /// <summary>
    /// Updates the specified area
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="picture"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Models.HassArea?> UpdateAreaAsync(this IHomeAssistantConnection connection, string id, string? name, 
        string? picture = default, CancellationToken cancellationToken = default)
   
        => connection.SendCommandAndReturnResponseAsync<HassAreaUpdate, Models.HassArea>(
            new HassAreaUpdate(id, name, picture), cancellationToken);

    #endregion

    #region Analytics

    /// <summary>
    /// Gets analytics preferences
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>Information about the current analytics preferences</returns>
    public static Task<HassAnalytics?> GetAnalyticsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassAnalyticsGet, HassAnalytics>(
            new HassAnalyticsGet(), cancellationToken);

    /// <summary>
    /// Sets analytics preferences
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="base"></param>
    /// <param name="diagnostics"></param>
    /// <param name="usage"></param>
    /// <param name="statistics"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>Information about the current analytics preferences</returns>
    public static Task<HassAnalytics?> SetAnalyticsAsync(this IHomeAssistantConnection connection, bool? @base, 
        bool? diagnostics = default, bool? statistics = default, bool? usage = default,
        CancellationToken cancellationToken = default)

        =>  connection.SendCommandAndReturnResponseAsync<HassAnalyticsSet, HassAnalytics>(
            new HassAnalyticsSet(@base, diagnostics, statistics, usage), cancellationToken);

    #endregion

    #region Auth

    /// <summary>
    /// Gets information about current user
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassUser?> GetCurrentUserAsync(this IHomeAssistantConnection connection,
         CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCurrentUser, HassUser>(
            new HassCurrentUser(), cancellationToken);

    /// <summary>
    /// Creates a long lived access token
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="lifeSpan">Use a value greater than or equal to 1 day</param>
    /// <param name="clientName"></param>
    /// <param name="clientIcon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string?> CreateAccessTokenAsync(this IHomeAssistantConnection connection, TimeSpan lifeSpan, 
        string clientName, string? clientIcon = default, CancellationToken cancellationToken = default)    

        => connection.SendCommandAndReturnResponseAsync<HassTokenCreate, string>(
            new HassTokenCreate(lifeSpan, clientName, clientIcon), cancellationToken) ;

    /// <summary>
    /// Lists the curent access tokens
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassAccessToken>?> GetAccessTokensAsync(this IHomeAssistantConnection connection,
         CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTokenList, IReadOnlyCollection<HassAccessToken>>(
            new HassTokenList(), cancellationToken);

    /// <summary>
    /// Deletes the specified token
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task DeleteAccessTokenAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)
  
        => connection.SendCommandAndReturnResponseAsync<HassTokenDelete, Object>(
            new HassTokenDelete(id), cancellationToken);

    /// <summary>
    /// Signs the specified path
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="path"></param>
    /// <param name="expires">default value is 30 seconds</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassPath?> SignPathAsync(this IHomeAssistantConnection connection, string path, 
        TimeSpan? expires = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassSignPath, HassPath>(
            new HassSignPath(path, expires), cancellationToken);

    /// <summary>
    /// Creates a new user
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="userId"></param>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task CreateUserAsync(this IHomeAssistantConnection connection, string userId, string userName, 
        string password, CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassUserCreate, Object>(
           new HassUserCreate(userId, userName, password), cancellationToken);

    /// <summary>
    /// Changes password for the specified user
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="userId"></param>
    /// <param name="password"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task ChangePasswordAsync(this IHomeAssistantConnection connection, string userId, string password, 
        CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassUserChangePassword, Object>(
           new HassUserChangePassword(userId, password), cancellationToken);

    #endregion

    #region Application Credentials 

    /// <summary>
    /// Gets a list of current credentials
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassCredential>?> GetCredentialsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCredentialsList, IReadOnlyCollection<HassCredential>>(
            new HassCredentialsList(), cancellationToken);


    /// <summary>
    /// Gets the current configuration for credentials
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCredentialsConfiguration?> GetCredentialsConfigurationAsync(this IHomeAssistantConnection connection,
         CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassCredentialsConfig, HassCredentialsConfiguration>(
            new HassCredentialsConfig(), cancellationToken);

    /// <summary>
    /// Deletes the specified credential
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task DeleteCredentialAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)
        
        => connection.SendCommandAndReturnResponseAsync<HassCredentialsDelete, Object>(
            new HassCredentialsDelete(id), cancellationToken);

    /// <summary>
    /// Creates a new credential
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="domain"></param>
    /// <param name="clientId"></param>
    /// <param name="clientSecret"></param>
    /// <param name="authDomain"></param>
    /// <param name="name"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCredential?> CreateCredentialAsync(this IHomeAssistantConnection connection, string domain, 
        string clientId, string clientSecret, string? authDomain = default, string? name = default, 
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCredentialsCreate, HassCredential>(
            new HassCredentialsCreate(domain, clientId, clientSecret, authDomain, name), cancellationToken);


    #endregion

    #region Backup

    /// <summary>
    /// Gets backup information
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassBackupInfo?> GetBackupInfoAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassBackupGetInfo, HassBackupInfo>(
            new HassBackupGetInfo(), cancellationToken);

    /// <summary>
    /// Deletes the specified backup
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="slug"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task DeleteBackupAsync(this IHomeAssistantConnection connection, string slug,
       CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassBackupDelete, Object>(
           new HassBackupDelete(slug), cancellationToken);

    /// <summary>
    /// Generates a new backup
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassBackup?> CreateBackupAsync(this IHomeAssistantConnection connection,
       CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassBackupCreate, HassBackup>(
           new HassBackupCreate(), cancellationToken);

    #endregion

    #region Blueprint

    /// <summary>
    /// Gets a list of blueprints
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="domain"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyDictionary<string, HassBlueprint>?> GetBlueprintsAsync(this IHomeAssistantConnection connection,
       HassBlueprintDomain domain, CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassBlueprintList, IReadOnlyDictionary<string, HassBlueprint>>(
           new HassBlueprintList(domain), cancellationToken);

    /// <summary>
    /// Imports a blueprint from the specified url
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="url"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassBlueprintImportResult?> ImportBlueprintAsync(this IHomeAssistantConnection connection,
      string url, CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassBlueprintImport, HassBlueprintImportResult>(
          new HassBlueprintImport(url), cancellationToken);

    /// <summary>
    /// Save the yaml blueprint definition to the specified path
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="domain"></param>
    /// <param name="path"></param>
    /// <param name="yaml"></param>
    /// <param name="sourceUrl"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task SaveBlueprintAsync(this IHomeAssistantConnection connection, HassBlueprintDomain domain,
        string path, string yaml, string? sourceUrl = default, CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassBlueprintSave, Object>(
          new HassBlueprintSave(domain, path, yaml, sourceUrl), cancellationToken);

    /// <summary>
    /// Deletes the specified blueprint
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="domain"></param>
    /// <param name="path"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassBlueprintImportResult?> DeleteBlueprintAsync(this IHomeAssistantConnection connection,
     HassBlueprintDomain domain, string path, CancellationToken cancellationToken = default)

     => connection.SendCommandAndReturnResponseAsync<HassBlueprintDelete, HassBlueprintImportResult>(
         new HassBlueprintDelete(domain, path), cancellationToken);

    #endregion

    #region Camera

    /// <summary>
    /// Gets the stream url for the specified camera
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="entityId"></param>
    /// <param name="format"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCameraStream?> GetCameraStreamAsync(this IHomeAssistantConnection connection, string entityId, 
        string? format = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassCameraGetStream, HassCameraStream>(
            new HassCameraGetStream(entityId, format), cancellationToken);

    /// <summary>
    /// Gets RTC offer for the specified camera
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="entityId"></param>
    /// <param name="offer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCameraAnswer?> GetCameraWebRtcOfferAsync(this IHomeAssistantConnection connection, string entityId,
        string offer, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassCameraGetWebRtc, HassCameraAnswer>(
            new HassCameraGetWebRtc(entityId, offer), cancellationToken);

    /// <summary>
    /// Gets the preferences for the specified camera
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="entityId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCameraPreferences?> GetCameraPreferences(this IHomeAssistantConnection connection, string entityId,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassCameraGetPrefs, HassCameraPreferences>(
            new HassCameraGetPrefs(entityId), cancellationToken);

    /// <summary>
    /// Gets the preferences for the specified camera 
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="entityId"></param>
    /// <param name="preloadStream"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCameraPreferences?> SetCameraPreferences(this IHomeAssistantConnection connection, string entityId,
        bool? preloadStream, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassCameraUpdatePrefs, HassCameraPreferences>(
            new HassCameraUpdatePrefs(entityId, preloadStream), cancellationToken);

    #endregion

    #region Cloud

    /// <summary>
    /// Logins to Home Assistant Cloud
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task CloudLogin(this IHomeAssistantConnection connection, string email, 
        string password, CancellationToken cancellationToken = default)
    {
        return connection.PostApiCallAsync<Object>("cloud/login", cancellationToken, new { email, password });
    }

    /// <summary>
    /// Logout from Home Assistant Cloud
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="email"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task CloudLogout(this IHomeAssistantConnection connection, string email,
        CancellationToken cancellationToken = default)
    {
        return connection.PostApiCallAsync<Object>("cloud/logout", cancellationToken, new { email });
    }

    /// <summary>
    /// Initiate a forgot password action
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="email"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task CloudForgotPassword(this IHomeAssistantConnection connection, string email,
        CancellationToken cancellationToken = default)
    {
        return connection.PostApiCallAsync<Object>("cloud/forgot_password", cancellationToken, new { email });
    }

    /// <summary>
    /// Registers to Home Assistant Cloud
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task CloudRegister(this IHomeAssistantConnection connection, string email, string password,
        CancellationToken cancellationToken = default)
    {
        return connection.PostApiCallAsync<Object>("cloud/register", cancellationToken, new { email, password });
    }

    /// <summary>
    /// Resend confirmation to Home Assistant Cloud
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="email"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task CloudResendConfirmation(this IHomeAssistantConnection connection, string email,
        CancellationToken cancellationToken = default)
    {
        return connection.PostApiCallAsync<Object>("cloud/resend_confirm", cancellationToken, new { email });

    }

    #endregion

    #region Counter

    /// <summary>
    /// Gets a list of counter helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassCounter>?> GetCountersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)
        
        => connection.SendCommandAndReturnResponseAsync<HassCounterList, IReadOnlyCollection<HassCounter>>(
            new HassCounterList(), cancellationToken);
    
    /// <summary>
    /// reates a new counter helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="minimum"></param>
    /// <param name="maximum"></param>
    /// <param name="restore">defaults to true if not specified</param>
    /// <param name="step">defaults to 1 if not specified</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCounter?> CreateCounterAsync(this IHomeAssistantConnection connection, string name, 
        string? icon = default, int? initialValue = default, int? step = default, int? minimum = default,
        int? maximum = default, bool? restore = default, CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCounterCreate, HassCounter>(
            new HassCounterCreate(name, icon, initialValue, step, minimum, maximum, restore), cancellationToken);

    /// <summary>
    /// Updates the specified counter helper.
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="minimum"></param>
    /// <param name="maximum"></param>
    /// <param name="restore"></param>
    /// <param name="step"></param>
    /// <returns></returns>
    public static Task<HassCounter?> UpdateCounterAsync(this IHomeAssistantConnection connection, string id, string? name, 
        string? icon = default, int? initialValue = default, int? step = default, int? minimum = default, 
        int? maximum = default, bool? restore = default, CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCounterUpdate, HassCounter>(
             new HassCounterUpdate(id, name, icon, initialValue, step, minimum, maximum, restore), cancellationToken);

    /// <summary>
    /// Deletes the specified counter helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteCounterAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCounterDelete, Object>(
            new HassCounterDelete(id), cancellationToken);

    #endregion
    
    #region Dashboard

    /// <summary>
    /// Gets a list of lovelace dashboards
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassDashboard>?> GetDashboardsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDashboardList, IReadOnlyCollection<HassDashboard>>(
            new HassDashboardList(), cancellationToken);

    /// <summary>
    /// Creates a new lovelace dashboard
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="title"></param>
    /// <param name="url"></param>
    /// <param name="requiresAdmin"></param>
    /// <param name="icon"></param>
    /// <param name="showInSidebar"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassDashboard?> CreateDashboardAsync(this IHomeAssistantConnection connection,
       string title, string url, bool? requiresAdmin = default, string? icon = default, bool? showInSidebar = default,
       HassDashboardMode? mode = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDashboardCreate, HassDashboard>(
            new HassDashboardCreate(title, url, requiresAdmin, icon, showInSidebar, mode), cancellationToken);

    /// <summary>
    /// Updates the specified lovelace dashboard
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="title"></param>
    /// <param name="requiresAdmin"></param>
    /// <param name="icon"></param>
    /// <param name="showInSidebar"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassDashboard?> UpdateDashboardAsync(this IHomeAssistantConnection connection, string id,
       string? title, bool? requiresAdmin = default, string? icon = default, bool? showInSidebar = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDashboardUpdate, HassDashboard>(
             new HassDashboardUpdate(id, title, requiresAdmin, icon, showInSidebar), cancellationToken);

    /// <summary>
    /// Deletes the specified lovelace dashboard
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteDashboardAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDashboardDelete, Object>(
            new HassDashboardDelete(id), cancellationToken);

    #endregion

    #region Image

    /// <summary>
    /// Gets a list of image helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassImage>?> GetImagesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageList, IReadOnlyCollection<HassImage>>(
            new HassImageList(), cancellationToken);

    /// <summary>
    /// Creates a new image helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="file"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassImage?> CreateImageAsync(this IHomeAssistantConnection connection, string file,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageCreate, HassImage>(
            new HassImageCreate(file), cancellationToken);

    /// <summary>
    /// Updates the specified image helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassImage?> UpdateImageAsync(this IHomeAssistantConnection connection, string id, string? name,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageUpdate, HassImage>(
             new HassImageUpdate(id, name), cancellationToken);

    /// <summary>
    /// Deletes the specified image helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteImageAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageDelete, Object>(
            new HassImageDelete(id), cancellationToken);

    #endregion

    #region InputBoolean

    /// <summary>
    /// Gets a list of input_boolean helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputBoolean>?> GetInputBooleansAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanList, IReadOnlyCollection<HassInputBoolean>>(
            new HassInputBooleanList(), cancellationToken);

    /// <summary>
    /// Creates a new input_boolean helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputBoolean?> CreateInputBooleanAsync(this IHomeAssistantConnection connection, string name, 
        bool? initialValue = default, string ? icon = default, 
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanCreate, HassInputBoolean>(
            new HassInputBooleanCreate(name, initialValue, icon), cancellationToken);

    /// <summary>
    /// Updates the specified input_boolean helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputBoolean?> UpdateInputBooleanAsync(this IHomeAssistantConnection connection, string id, 
        string? name, bool ? initialValue = default, string? icon = default,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanUpdate, HassInputBoolean>(
             new HassInputBooleanUpdate(id, name, initialValue, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified input_boolean helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputBooleanAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanDelete, Object>(
            new HassInputBooleanDelete(id), cancellationToken);

    #endregion

    #region InputButton

    /// <summary>
    /// Gets a list of input_button helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputButton>?> GetInputButtonsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonList, IReadOnlyCollection<HassInputButton>>(
            new HassInputButtonList(), cancellationToken);

    /// <summary>
    /// Creates a new input_button helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputButton?> CreateInputButtonAsync(this IHomeAssistantConnection connection, string name,
       string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonCreate, HassInputButton>(
            new HassInputButtonCreate(name, icon), cancellationToken);

    /// <summary>
    /// Updates the specified input_button helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputButton?> UpdateInputButtonAsync(this IHomeAssistantConnection connection, string id,
        string? name, string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonUpdate, HassInputButton>(
             new HassInputButtonUpdate(id, name, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified input_button helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputButtonAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonDelete, Object>(
            new HassInputButtonDelete(id), cancellationToken);

    #endregion

    #region InputDateTime

    /// <summary>
    /// Gets a list of input_datetime helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputDateTime>?> GetInputDateTimesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeList, IReadOnlyCollection<HassInputDateTime>>(
            new HassInputDateTimeList(), cancellationToken);

    /// <summary>
    /// Creates a new input_datetime helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="hasDate"></param>
    /// <param name="hasTime"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputDateTime?> CreateInputDateTimeAsync(this IHomeAssistantConnection connection, string name,
       bool? hasDate = default, bool? hasTime = default, string? icon = default, DateTime? initialValue = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeCreate, HassInputDateTime>(
            new HassInputDateTimeCreate(name, hasDate, hasTime, icon, initialValue), cancellationToken);

    /// <summary>
    /// Updates the specified input_datetime helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="hasDate"></param>
    /// <param name="hasTime"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputDateTime?> UpdateInputDateTimeAsync(this IHomeAssistantConnection connection, string id,
       string? name, bool? hasDate = default, bool? hasTime = default, string? icon = default, DateTime? initialValue = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeUpdate, HassInputDateTime>(
             new HassInputDateTimeUpdate(id, name, hasDate, hasTime, icon, initialValue), cancellationToken);

    /// <summary>
    /// Deletes the specified input_datetime helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputDateTimeAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeDelete, Object>(
            new HassInputDateTimeDelete(id), cancellationToken);

    #endregion

    #region InputNumber

    /// <summary>
    /// Gets a list of input_number helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputNumber>?> GetInputNumbersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberList, IReadOnlyCollection<HassInputNumber>>(
            new HassInputNumberList(), cancellationToken);

    /// <summary>
    /// Creates a new input_number helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="initialValue"></param>
    /// <param name="step"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputNumber?> CreateInputNumberAsync(this IHomeAssistantConnection connection, string name,
        double min, double max, double? initialValue = default, double? step = default, string? icon = default, 
        string? unitOfMeasurement = default, HassInputNumberMode? mode = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberCreate, HassInputNumber>(
            new HassInputNumberCreate(name, min, max, initialValue, step, icon, unitOfMeasurement, mode), cancellationToken);

    /// <summary>
    /// Updates the specified input_number helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="initialValue"></param>
    /// <param name="step"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputNumber?> UpdateInputNumberAsync(this IHomeAssistantConnection connection, string id,
        string? name = default, double? min = default, double? max = default, double? initialValue = default, 
        double? step = default, string? icon = default, string? unitOfMeasurement = default, 
        HassInputNumberMode? mode = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberUpdate, HassInputNumber>(
            new HassInputNumberUpdate(id, name, min, max, initialValue, step, icon, unitOfMeasurement, mode), cancellationToken);

    /// <summary>
    /// Deletes the specified input_number helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputNumberAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberDelete, Object>(
            new HassInputNumberDelete(id), cancellationToken);

    #endregion

    #region InputSelect

    /// <summary>
    /// Gets a list of input_select helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputSelect>?> GetInputSelectsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectList, IReadOnlyCollection<HassInputSelect>>(
            new HassInputSelectList(), cancellationToken);

    /// <summary>
    /// Creates a new input_select helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="options"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputSelect?> CreateInputSelectAsync(this IHomeAssistantConnection connection, string name,
       IEnumerable<string> options, string? initialValue = default, string? icon = default, 
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectCreate, HassInputSelect>(
            new HassInputSelectCreate(name, options, initialValue, icon), cancellationToken);

    /// <summary>
    /// Updates the specified input_select helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="options"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputSelect?> UpdateInputSelectAsync(this IHomeAssistantConnection connection, string id,
         string? name, IEnumerable<string> options, string? initialValue = default, string? icon = default,
         CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectUpdate, HassInputSelect>(
             new HassInputSelectUpdate(id, name, options, initialValue, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified input_select helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputSelectAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectDelete, Object>(
            new HassInputSelectDelete(id), cancellationToken);

    #endregion

    #region InputText

    /// <summary>
    /// Gets a list of input_text helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputText>?> GetInputTextsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputTextList, IReadOnlyCollection<HassInputText>>(
            new HassInputTextList(), cancellationToken);

    /// <summary>
    /// Creates a new input_text helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="minLength"></param>
    /// <param name="maxLength"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="pattern"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputText?> CreateInputTextAsync(this IHomeAssistantConnection connection, string name, 
        int? minLength = default, int? maxLength = default, string? initialValue = default, string? icon = default, 
        string? unitOfMeasurement = default, string? pattern = default, HassInputTextMode? mode = default, 
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputTextCreate, HassInputText>(
            new HassInputTextCreate(name, minLength, maxLength, initialValue, icon, unitOfMeasurement, pattern, mode),
            cancellationToken);

    /// <summary>
    /// Updates the specified input_text helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="minLength"></param>
    /// <param name="maxLength"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="pattern"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputText?> UpdateInputTextAsync(this IHomeAssistantConnection connection, string id, 
       string? name = default, int? minLength = default, int? maxLength = default, string? initialValue = default, 
       string? icon = default, string? unitOfMeasurement = default, string? pattern = default, 
       HassInputTextMode? mode = default, CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassInputTextUpdate, HassInputText>(
           new HassInputTextUpdate(id, name, minLength, maxLength, initialValue, icon, unitOfMeasurement, pattern, mode),
           cancellationToken);

    /// <summary>
    /// Deletes the specified input_text helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputTextAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputTextDelete, Object>(
            new HassInputTextDelete(id), cancellationToken);

    #endregion

    #region Resource

    /// <summary>
    /// Gets a list of lovelace dashboards
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassResource>?> GetResourcesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassResourceList, IReadOnlyCollection<HassResource>>(
            new HassResourceList(), cancellationToken);

    /// <summary>
    /// Creates a new lovelace dashboard
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="type"></param>
    /// <param name="url"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassResource?> CreateResourceAsync(this IHomeAssistantConnection connection, HassResourceType type,
       string url, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassResourceCreate, HassResource>(
            new HassResourceCreate(type, url), cancellationToken);

    /// <summary>
    /// Updates the specified lovelace dashboard
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="type"></param>
    /// <param name="url"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassResource?> UpdateResourceAsync(this IHomeAssistantConnection connection, string id,
        HassResourceType? type = default, string? url = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassResourceUpdate, HassResource>(
             new HassResourceUpdate(id, type, url), cancellationToken);

    /// <summary>
    /// Deletes the specified lovelace dashboard
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteResourceAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassResourceDelete, Object>(
            new HassResourceDelete(id), cancellationToken);

    #endregion

    #region Person

    /// <summary>
    /// Gets a list of persons
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassPerson>?> GetPersonsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonList, IReadOnlyCollection<HassPerson>>(
            new HassPersonList(), cancellationToken);

   /// <summary>
   /// Creates a new person
   /// </summary>
   /// <param name="connection"></param>
   /// <param name="name"></param>
   /// <param name="userId"></param>
   /// <param name="deviceTrackers"></param>
   /// <param name="picture"></param>
   /// <param name="cancellationToken"></param>
   /// <returns></returns>
    public static Task<HassPerson?> CreatePersonAsync(this IHomeAssistantConnection connection,
       string name, string? userId = default, IEnumerable<string>? deviceTrackers = default, string? picture = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonCreate, HassPerson>(
            new HassPersonCreate(name, userId, deviceTrackers, picture), cancellationToken);

    /// <summary>
    /// Updates the specified person
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="userId"></param>
    /// <param name="deviceTrackers"></param>
    /// <param name="picture"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassPerson?> UpdatePersonAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, string? userId = default, IEnumerable<string>? deviceTrackers = default, 
       string? picture = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonUpdate, HassPerson>(
             new HassPersonUpdate(id, name, userId, deviceTrackers, picture), cancellationToken);

    /// <summary>
    /// Deletes the specified lovelace person
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeletePersonAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonDelete, Object>(
            new HassPersonDelete(id), cancellationToken);

    #endregion

    #region Tag

    /// <summary>
    /// Gets a list of tags
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassTag>?> GetTagsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagList, IReadOnlyCollection<HassTag>>(
            new HassTagList(), cancellationToken);

    /// <summary>
    /// Creates a new tag
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="lastScanned"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTag?> CreateTagAsync(this IHomeAssistantConnection connection,
       string? id = default, string? name = default, string? description = default, DateTime? lastScanned = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagCreate, HassTag>(
            new HassTagCreate(id, name, description, lastScanned), cancellationToken);

    /// <summary>
    /// Updates the specified tag
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="lastScanned"></param>
    /// <param name="picture"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTag?> UpdateTagAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, string? description = default, DateTime? lastScanned = default,
       string? picture = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagUpdate, HassTag>(
             new HassTagUpdate(id, name, description, lastScanned), cancellationToken);

    /// <summary>
    /// Deletes the specified ag
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteTagAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagDelete, Object>(
            new HassTagDelete(id), cancellationToken);

    #endregion

    #region Timer

    /// <summary>
    /// Gets a list of timers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassTimer>?> GetTimersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerList, IReadOnlyCollection<HassTimer>>(
            new HassTimerList(), cancellationToken);

    /// <summary>
    /// Creates a new timer
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="duration"></param>
    /// <param name="restore"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTimer?> CreateTimerAsync(this IHomeAssistantConnection connection,
       string name, string? icon = default, TimeSpan? duration = default, bool? restore = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerCreate, HassTimer>(
            new HassTimerCreate(name, icon, duration, restore), cancellationToken);

    /// <summary>
    /// Updates the specified timer
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="duration"></param>
    /// <param name="restore"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTimer?> UpdateTimerAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, string? icon = default, TimeSpan? duration = default, bool? restore = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerUpdate, HassTimer>(
             new HassTimerUpdate(id, name, icon, duration, restore), cancellationToken);

    /// <summary>
    /// Deletes the specified timer
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteTimerAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerDelete, Object>(
            new HassTimerDelete(id), cancellationToken);

    #endregion

    #region Zone

    /// <summary>
    /// Gets a list of zones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassZone>?> GetZonesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneList, IReadOnlyCollection<HassZone>>(
            new HassZoneList(), cancellationToken);

    /// <summary>
    /// Creates a new zone
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="radius"></param>
    /// <param name="passive"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassZone?> CreateZoneAsync(this IHomeAssistantConnection connection,
       string name, double latitude, double longitude, double? radius = default, bool? passive = default, 
       string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneCreate, HassZone>(
            new HassZoneCreate(name, latitude, longitude, radius, passive, icon), cancellationToken);

    /// <summary>
    /// Updates the specified zone
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="radius"></param>
    /// <param name="passive"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassZone?> UpdateZoneAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, double? latitude = default, double? longitude = default, double? radius = default, 
       bool? passive = default, string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneUpdate, HassZone>(
             new HassZoneUpdate(id, name, latitude, longitude, radius, passive, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified zone
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteZoneAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneDelete, Object>(
            new HassZoneDelete(id), cancellationToken);

    #endregion

}


