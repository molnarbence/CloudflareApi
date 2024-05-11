using CloudflareApi.Client.DnsRecords;
using CloudflareApi.Client.Zones;
using Refit;

namespace CloudflareApi.Client;

public interface IZonesApi
{
   [Get("/")]
   Task<GetZonesResponse> GetZonesAsync();

   [Get("/{zoneId}/dns_records")]
   Task<GetDnsRecordsResponse> GetDnsRecordsAsync(string zoneId);

   [Get("/{zoneId}/dns_records/{dnsRecordId}")]
   Task<GetDnsRecordResponse> GetDnsRecordAsync(string zoneId, string dnsRecordId);

   [Patch("/{zoneId}/dns_records/{dnsRecordId}")]
   Task<UpdateDnsRecordResponse> UpdateDnsRecordAsync(string zoneId, string dnsRecordId, [Body] DnsRecordDto dnsRecordInfo);
}
