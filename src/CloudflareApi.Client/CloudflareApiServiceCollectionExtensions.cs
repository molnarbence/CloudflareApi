using CloudflareApi.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Microsft.Extensions.DependencyInjection;
public static class CloudflareApiServiceCollectionExtensions
{
   private const string ApiBaseAddress = "https://api.cloudflare.com/client/v4";

   public static IServiceCollection AddCloudflareApi(this IServiceCollection services, IConfiguration configuration) => services.AddCloudflareApi(configuration, null);

   public static IServiceCollection AddCloudflareApi(this IServiceCollection services, IConfiguration configuration, Action<IHttpClientBuilder>? httpClientBuilder)
   {
      services
         .AddTransient<CloudflareAuthorizationDelegatingHandler>()
         .AddOptions<CloudflareConfiguration>()
         .Bind(configuration.GetSection(CloudflareConfiguration.SectionName))
         .ValidateDataAnnotations()
         .ValidateOnStart();

      var zonesApiBuilder = services
         .AddRefitClient<IZonesApi>()
         .ConfigureHttpClient(client => client.BaseAddress = new Uri($"{ApiBaseAddress}/zones"))
         .AddHttpMessageHandler<CloudflareAuthorizationDelegatingHandler>();

      if (httpClientBuilder is not null)
      {
         httpClientBuilder(zonesApiBuilder);
      }

      return services;
   }
}
