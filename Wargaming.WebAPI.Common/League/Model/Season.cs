using Newtonsoft.Json;
using Wargaming.WebAPI.Common.Enums;

namespace Wargaming.WebAPI.Common.Model
{
    public class Season
    {
        /// <summary>
        /// Season ID
        /// </summary>
        [JsonProperty("season_id")]
        public int SeasonId { get; set; }

        /// <summary>
        /// Season name
        /// </summary>
        [JsonProperty("name_i18n")]
        public string SeasonNameLocalized { get; set; }

        /// <summary>
        /// Season status: 'active' or 'complete'
        /// </summary>
        [JsonProperty("status")]
        public string LeagueStatusValue
        {
            get { return this.Status.ReplaceEventStatus(); }
            set { this.Status = value.ReplaceEventStatus(); }
        }

        /// <summary>
        /// Season status: 'active' or 'complete'
        /// </summary>
        [JsonIgnore]
        public EventStatus Status { get; set; }
    }
}