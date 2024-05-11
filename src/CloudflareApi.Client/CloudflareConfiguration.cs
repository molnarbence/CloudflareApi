namespace CloudflareApi.Client;
public class CloudflareConfiguration
{
   public const string SectionName = "Cloudflare";

   public required string ApiKey { get; set; }
   public required string ZoneId { get; set; }
   public required string RecordId { get; set; }
}

