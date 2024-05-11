namespace CloudflareApi.Client;

public abstract class ResponseBase<TResult>
{
   public IEnumerable<object> Errors { get; set; } = [];
   public IEnumerable<object> Messages { get; set; } = [];
   public bool Success { get; set; }
   public required TResult Result { get; set; }
}
