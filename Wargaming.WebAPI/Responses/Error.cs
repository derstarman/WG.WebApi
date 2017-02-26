using Newtonsoft.Json;

namespace Wargaming.WebAPI.Responses
{
    public class Error
    {
        [JsonProperty("field")]
        public string RequestField { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("value")]
        public string FieldValue { get; set; }

        [JsonProperty("code")]
        public int ErrorCode { get; set; }
    }
}