using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
	public class TournamentBracketMatch
	{
		/// <summary>
		/// Match ID
		/// </summary>
		[JsonProperty("match_id")]
		public int MatchId { get; set; }

		/// <summary>
		/// Match position in the bracket. 'winner' and 'loser' — corresponding branches for winners and losers. If it is the first round, field value is 'null'.
		/// </summary>
		[JsonProperty("bracket")]
		public string Bracket { get; set; }

		/// <summary>
		/// Match round in the tournament
		/// </summary>
		[JsonProperty("round")]
		public int TournamentRound { get; set; }

		/// <summary>
		/// Match position in round
		/// </summary>
		[JsonProperty("position")]
		public int? Position { get; set; }

		/// <summary>
		/// Match start time. If the match has not started yet, field value is 'null'.
		/// </summary>
		[JsonProperty("start_at")]
		private double? StartAtValue
		{
			get { return this.StartAt.ToDouble(); }
			set { this.StartAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Match start time. If the match has not started yet, field value is 'null'.
		/// </summary>
		[JsonIgnore]
		public DateTime? StartAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Loser's next match
		/// </summary>
		[JsonProperty("loser")]
		public TournamentBracketNextMatch Loser { get; set; }

		/// <summary>
		/// Winner's next match
		/// </summary>
		[JsonProperty("winner")]
		public TournamentBracketNextMatch Winner { get; set; }
	}
}