using Newtonsoft.Json;
using Wargaming.WebAPI.Common.Enums;

namespace Wargaming.WebAPI.Common.Model
{
    public class TournamentBracketNextMatch
    {
        /// <summary>
        /// ID of the next match for the team in the tournament
        /// </summary>
        [JsonProperty("next_match_id")]
        public int NextMatchId { get; set; }

        /// <summary>
        /// ID of the next round for the team
        /// </summary>
        [JsonProperty("next_round")]
        public int NextRound { get; set; }

        /// <summary>
        /// Team position in the match: 'left' or 'right'
        /// </summary>
        [JsonProperty("team_in_match")]
        public string NextPositionValue
        {
            get { return this.NextPosition.ReplaceMatchPosition(); }
            set { this.NextPosition = value.ReplaceMatchPosition(); }
        }

        /// <summary>
        /// Team position in the match: 'left' or 'right'
        /// </summary>
        [JsonIgnore]
        public MatchPosition NextPosition { get; set; }
    }
}