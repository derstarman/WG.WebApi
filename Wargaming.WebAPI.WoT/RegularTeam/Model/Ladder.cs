using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
    public class Ladder
    {
        /// <summary>
        /// Division level
        /// </summary>
        [JsonProperty("division")]
        public int Division { get; set; }

        /// <summary>
        /// Group number
        /// </summary>
        [JsonProperty("group")]
        public int Group { get; set; }

        /// <summary>
        /// Ladder points
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// Position in team
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}