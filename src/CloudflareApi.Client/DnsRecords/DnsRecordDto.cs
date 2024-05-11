namespace CloudflareApi.Client.DnsRecords;
public class DnsRecordDto
{
   public required string Name { get; set; }
   public required string Content { get; set; }
   public required string Type { get; set; }
}