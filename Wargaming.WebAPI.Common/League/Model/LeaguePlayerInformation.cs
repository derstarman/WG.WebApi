using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.Common.Model
{
    public class LeaguePlayerInformation : LeaguePlayer
    {
        /// <summary>
        /// Player's city/town
        /// </summary>
        [JsonProperty("city")]
        public string PlayerCity { get; set; }

        /// <summary>
        /// Player's country
        /// </summary>
        [JsonProperty("country")]
        public string PlayerCountry { get; set; }
        
        /// <summary>
        /// Player's date of birth, YYYY-MM-DD
        /// </summary>
        [JsonProperty("date_of_birth")]
        public string PlayerDateOfBirth { get; set; }

        /// <summary>
        /// Player name
        /// </summary>
        [JsonProperty("first_name")]
        public string PlayerFirstName { get; set; }

        /// <summary>
        /// Player's last name
        /// </summary>
        [JsonProperty("last_name")]
        public string PlayerLastName { get; set; }

        /// <summary>
        /// ID of the team in which the player is the captain. If the player is not a captain of any team, field value is 'null'.
        /// </summary>
        [JsonProperty("own_team_id")]
        public int? OwnerOfTeam { get; set; }

        /// <summary>
        /// Link to player's photo
        /// </summary>
        [JsonProperty("photo_url")]
        private string PlayerPhotoValue
        {
            get { return this.PlayerPhoto != null ? this.PlayerPhoto.ToString() : null; }
            set { this.PlayerPhoto = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to player's photo
        /// </summary>
        [JsonIgnore]
        public Uri PlayerPhoto { get; set; }

        /// <summary>
        /// Player statistics
        /// </summary>
        [JsonProperty("statistics")]
        public LeaguePlayerStatistics PlayerStatistics { get; set; }
    }
}
