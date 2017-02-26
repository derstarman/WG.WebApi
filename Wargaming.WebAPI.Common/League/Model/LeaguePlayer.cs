using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.Common.Model
{
    public class LeaguePlayer
    {
        /// <summary>
        /// Player account ID
        /// </summary>
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        /// Player user name
        /// </summary>
        [JsonProperty("nickname")]
        public string AccountName { get; set; }

        /// <summary>
        /// List of player teams' IDs
        /// </summary>
        [JsonProperty("team_ids")]
        public List<int> TeamIds { get; set; }
    }
}