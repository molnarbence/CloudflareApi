using System.Text.Json.Serialization;

namespace CloudflareApi.Client;
public class ResultInfo
{
   public int Count { get; set; }
   public int Page { get; set; }
   [JsonPropertyName("per_page")]
   public int PerPage { get; set; }
   [JsonPropertyName("total_count")]
   public int TotalCount { get; set; }
}
