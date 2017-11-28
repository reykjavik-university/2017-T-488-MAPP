
namespace MovieDownload
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public sealed class StorageClient : IImageStorage
    {
        private readonly string ImageUrl = "http://image.tmdb.org/t/p/original";
        private readonly HttpClient _httpClient;

        public StorageClient()
        {
            HttpClientHandler handler = new HttpClientHandler
            {
                PreAuthenticate = true,
                UseDefaultCredentials = true
            };

            this._httpClient = new HttpClient(handler);
        }

        public async Task DownloadAsync(string fileName, Stream outputStream, CancellationToken cancellationToken)
        {
            var requestUri = new Uri(String.Concat(this.ImageUrl, fileName));
            
            var response = await this._httpClient.GetAsync(requestUri,
                HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            var content = response.EnsureSuccessStatusCode().Content;
            await content.CopyToAsync(outputStream).ConfigureAwait(false);
        }
    }
}
