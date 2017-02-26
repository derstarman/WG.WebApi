using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public class Server
    {
        [JsonProperty("players_online")]
        public int OnlinePlayers { get; set; }

        [JsonProperty("server")]
        public string ServerName { get; set; }
    }
}