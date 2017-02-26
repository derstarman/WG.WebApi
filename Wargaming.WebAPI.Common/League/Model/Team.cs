using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
    public class Team
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
        [JsonProperty("abbreviation")]
        public string TeamTag { get; set; }

        /// <summary>
        /// Team captain account ID. If there is no captain, field value is 'null'.
        /// </summary>
        [JsonProperty("captain_id")]
        public int? TeamCaptainId { get; set; }

        /// <summary>
        /// Link to team logo
        /// </summary>
        [JsonProperty("logo_url")]
        private string TeamLogoValue
        {
            get { return this.TeamLogo != null ? this.TeamLogo.ToString() : null; }
            set { this.TeamLogo = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to team logo
        /// </summary>
        [JsonIgnore]
        public Uri TeamLogo { get; set; }
    }
}