using System.Text.Json.Serialization;

namespace CloudflareApi.Client;

public abstract class ListResponseBase<TResult> : ResponseBase<IEnumerable<TResult>>
{
   [JsonPropertyName("result_info")]
   public required ResultInfo ResultInfo { get; set; }
}
