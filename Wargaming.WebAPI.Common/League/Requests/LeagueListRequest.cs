using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Common.Enums;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
    public class LeagueListRequest : ListRequestBase
    {
        /// <summary>
        /// League ID's
        /// </summary>
        [JsonProperty("league_id")]
        private string RequestedLeagueIdsValue
        {
            get { return string.Join(",", this.RequestedLeagueIds); }
            set { this.RequestedLeagueIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
        }

        /// <summary>
        /// League ID's
        /// </summary>
        [JsonIgnore]
        public List<int> RequestedLeagueIds { get; set; } = new List<int>();

        /// <summary>
        /// League status.
        /// </summary>
        [JsonProperty("status")]
        public string LeagueStatusValue
        {
            get { return this.LeagueStatus.ReplaceEventStatus(); }
            set { this.LeagueStatus = value.ReplaceEventStatus(); }
        }

        /// <summary>
        /// League status.
        /// </summary>
        [JsonIgnore]
        public EventStatus LeagueStatus { get; set; }
    }
}