using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public class TeamStatistics
    {
        /// <summary>
        /// Total matches played
        /// </summary>
        [JsonProperty("battles")]
        public int Battles { get; set; }

        /// <summary>
        /// Matches won
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}