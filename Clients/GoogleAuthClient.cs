using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetTest.Clients
{
    public class GoogleAuthClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _appName;
        private readonly string _secretCode;

        public GoogleAuthClient(HttpClient httpClient, string appName, string secretCode)
        {
            _httpClient = httpClient;
            _appName = appName;
            _secretCode = secretCode;
        }

        public async Task<byte[]> GetQR(string username,
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(
                $"/pair.aspx?AppName={_appName}&AppInfo={username}&SecretCode={_secretCode}",
                cancellationToken);

            _ = response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsByteArrayAsync(cancellationToken);
        }

        public async Task<bool> IsValid(string pin,
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(
                $"/Validate.aspx?Pin={pin}&SecretCode={_secretCode}",
                cancellationToken);

            _ = response.EnsureSuccessStatusCode();

            string serialized = await response.Content.ReadAsStringAsync(cancellationToken);
            return bool.Parse(serialized);
        }
    }
}