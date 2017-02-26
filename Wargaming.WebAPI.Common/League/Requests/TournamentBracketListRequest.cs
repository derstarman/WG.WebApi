using Newtonsoft.Json;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
    public class TournamentBracketListRequest : RequestBase
    {
        /// <summary>
        /// Tournament ID
        /// </summary>
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }
    }
}