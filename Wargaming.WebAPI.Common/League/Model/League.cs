using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Wargaming.WebAPI.Common.Enums;

namespace Wargaming.WebAPI.Common.Model
{
    public class League
    {
        /// <summary>
        /// League ID
        /// </summary>
        [JsonProperty("league_id")]
        public int LeagueId { get; set; }

        /// <summary>
        /// Parent league ID
        /// </summary>
        [JsonProperty("parent_id")]
        public int ParentLeagueId { get; set; }

        /// <summary>
        /// Localized league name
        /// </summary>
        [JsonProperty("name_i18n")]
        public string LeagueNameLocalized { get; set; }

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

        /// <summary>
        /// Date when league details were updated
        /// </summary>
        [JsonProperty("updated_at")]
        private double UpdatedAtValue
        {
            get { return this.UpdatedAt.ToDouble(); }
            set { this.UpdatedAt = value.ToDateTime(); }
        }

        /// <summary>
        /// Date when league details were updated
        /// </summary>
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

        /// <summary>
        /// List of league seasons
        /// </summary>
        [JsonProperty("seasons")]
        public List<Season> Seasons { get; set; }

        /// <summary>
        /// List of league stages
        /// </summary>
        [JsonProperty("stages")]
        public List<Stage> Stages { get; set; }
    }
}