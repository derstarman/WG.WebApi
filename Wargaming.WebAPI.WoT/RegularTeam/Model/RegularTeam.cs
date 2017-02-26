using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
    public class RegularTeam
    {
        /// <summary>
        /// Team ID
        /// </summary>
        [JsonProperty("team_id")]
        public int TeamId { get; set; }

        /// <summary>
        /// Team name
        /// </summary>
        [JsonProperty("name")]
        public string TeamName { get; set; }

        /// <summary>
        /// Team tag
        /// </summary>
        [JsonProperty("tag")]
        public string TeamTag { get; set; }

        /// <summary>
        /// Team captain account ID.
        /// </summary>
        [JsonProperty("captain_id")]
        public int TeamCaptainId { get; set; }

        /// <summary>
        /// Number of team members
        /// </summary>
        [JsonProperty("members_count ")]
        public int TeamMembersCount { get; set; }

        /// <summary>
        /// Team emblems
        /// </summary>
        [JsonProperty("emblems")]
        public Emblems Emblems { get; set; }

        /// <summary>
        /// Position in Ranked Battles
        /// </summary>
        [JsonProperty("ladder")]
        public Ladder Ladder { get; set; }
    }
}