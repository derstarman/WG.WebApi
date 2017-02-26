using Newtonsoft.Json;

namespace Wargaming.WebAPI.Responses
{
    public class Meta
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}