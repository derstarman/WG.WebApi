using Newtonsoft.Json;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
    public class LeaguePlayerListRequest : SearchRequestBase
    {
        /// <summary>
        /// Team ID
        /// </summary>
        [JsonProperty("team_id")]
        public int TeamId { get; set; }
    }
}