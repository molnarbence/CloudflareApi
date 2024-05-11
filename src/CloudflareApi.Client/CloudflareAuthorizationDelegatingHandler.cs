using System.Net.Http.Headers;
using Microsoft.Extensions.Options;

namespace CloudflareApi.Client;
internal class CloudflareAuthorizationDelegatingHandler(IOptions<CloudflareConfiguration> options) : DelegatingHandler
{
   private readonly IOptions<CloudflareConfiguration> _options = options;
   protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   {
      request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.Value.ApiKey);
      return base.SendAsync(request, cancellationToken);
   }
}

