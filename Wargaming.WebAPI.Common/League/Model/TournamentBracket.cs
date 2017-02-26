using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.Common.Model
{
    public class TournamentBracket
    {
        /// <summary>
        /// Tournament round
        /// </summary>
        [JsonProperty("round")]
        public int TournamentRound { get; set; }

        /// <summary>
        /// List of matches in the round
        /// </summary>
        [JsonProperty("matches")]
        public List<TournamentBracketMatch> Matches { get; set; }
    }
}