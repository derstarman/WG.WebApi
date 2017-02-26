using Newtonsoft.Json;
using Wargaming.WebAPI.Common.Enums;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
    public class TeamListRequest : SearchRequestBase
    {
        /// <summary>
        /// Search parameter. Default value: abbreviation.
        /// </summary>
        [JsonProperty("search_by")]
        public string TeamSearchTypeValue
        {
            get { return this.TeamSearchType.ReplaceTeamSearchType(); }
            set { this.TeamSearchType = value.ReplaceTeamSearchType(); }
        }

        /// <summary>
        /// Search parameter. Default value: abbreviation.
        /// </summary>
        [JsonIgnore]
        public TeamSearchType TeamSearchType { get; set; }
    }
}