using Newtonsoft.Json;

namespace Wargaming.WebAPI.Responses
{
    public abstract class ResponseBase<TResult> : ResponseBase
    {
        [JsonProperty("data")]
        public TResult Result { get; set; }
    }

    public abstract class ResponseBase
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("meta")]
        public Meta MetaInformation { get; set; }

        [JsonProperty("error")]
        public Error Error { get; set; }        
    }
}