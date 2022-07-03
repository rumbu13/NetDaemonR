using Microsoft.Extensions.Options;
using NetDaemon.Client.Internal.Exceptions;
using NetDaemon.Client.Settings;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Client.Internal
{
    internal class HomeAssistantRestManager : IHomeAssistantRestManager
    {
        readonly string restUrl;
        readonly HttpClient httpClient;

        readonly JsonSerializerOptions serializerOptions = new()
        {
            WriteIndented = false,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull            
        };

        public HomeAssistantRestManager(IOptions<HomeAssistantSettings> settings)
        {
            this.httpClient = new HttpClient(new HttpClientHandler()
            { 
                ServerCertificateCustomValidationCallback = (msg, certificate, chain, policy) 
                    => settings.Value.InsecureBypassCertificateErrors || policy == SslPolicyErrors.None 
                
            });
            var httpScheme = settings.Value.Ssl ? "https" : "http";
            this.restUrl = $"{httpScheme}://{settings.Value.Host}:{settings.Value.Port}";

            this.httpClient.DefaultRequestHeaders.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {settings.Value.Token}");
        }

        public async Task<T?> DeleteRestCallAsync<T>(string restPath, CancellationToken cancellationToken)
        {
            var url = $"{restUrl}/{restPath}";

            var result = await httpClient.DeleteAsync(new Uri(url), cancellationToken).ConfigureAwait(false);

            if (result.IsSuccessStatusCode)
            {
                if (result.Content.Headers.ContentLength == 0)
                    return default;

                var stream = await result.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                return await JsonSerializer.DeserializeAsync<T>(stream, options: null, cancellationToken)
                    .ConfigureAwait(false);
            }

            throw new HomeAssistantApiCallException(
                $"Rest get call to '{restPath}' failed, code '{result.StatusCode}', reason: '{result.ReasonPhrase}'", result.StatusCode);
        }

        public async Task<T?> GetRestCallAsync<T>(string restPath, CancellationToken cancellationToken)
        {
            var url = $"{restUrl}/{restPath}";

            var result = await httpClient.GetAsync(new Uri(url), cancellationToken).ConfigureAwait(false);

            if (result.IsSuccessStatusCode)
            {
                if (result.Content.Headers.ContentLength == 0)
                    return default;

                var stream = await result.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                return await JsonSerializer.DeserializeAsync<T>(stream, options: null, cancellationToken)
                    .ConfigureAwait(false);
            }

            throw new HomeAssistantApiCallException(
                $"Rest get call to '{restPath}' failed, code '{result.StatusCode}', reason: '{result.ReasonPhrase}'", result.StatusCode);
        }

        public async Task<T?> PostRestCallAsync<T>(string restPath, CancellationToken cancellationToken, object? data = null)
        {
            var url = $"{restUrl}/{restPath}";
            var content = "";

            if (data != null) content = JsonSerializer.Serialize(data, serializerOptions);
            using var sc = new StringContent(content, Encoding.UTF8);

            if (content.Length > 0) sc.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            var result = await httpClient.PostAsync(new Uri(url), sc, cancellationToken).ConfigureAwait(false);

            if (result.IsSuccessStatusCode)
            {
                if (result.Content.Headers.ContentLength == 0)
                    return default;

                var stream = await result.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return await JsonSerializer.DeserializeAsync<T>(stream, options: null, cancellationToken)
                    .ConfigureAwait(false);
            }

            throw new HomeAssistantApiCallException(
                $"Rest post call to '{restPath}' failed, code '{result.StatusCode}', reason: '{result.ReasonPhrase}'", result.StatusCode);
        }
    }
}
