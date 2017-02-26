using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
	public class TournamentMatch
	{
		/// <summary>
		/// Tournament ID
		/// </summary>
		[JsonProperty("tournament_id")]
		public int TournamentId { get; set; }

		/// <summary>
		/// Match ID
		/// </summary>
		[JsonProperty("match_id")]
		public int MatchId { get; set; }

		/// <summary>
		/// Match round in the tournament
		/// </summary>
		[JsonProperty("round")]
		public int TorunamentRound { get; set; }

		/// <summary>
		/// Match position in round
		/// </summary>
		[JsonProperty("position")]
		public int Position { get; set; }

		/// <summary>
		/// Match position in the bracket. 'winner' and 'loser' — corresponding branches for winners and losers. If it is the first round, field value is 'null'.
		/// </summary>
		[JsonProperty("bracket")]
		public string Bracket { get; set; }

		/// <summary>
		/// Map where the battles are held
		/// </summary>
		[JsonProperty("arena_id")]
		public string Arena { get; set; }

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
		/// Date of the last match info update
		/// </summary>
		[JsonProperty("updated_at")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date of the last match info update
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// ID of the left team participating in the tournament
		/// </summary>
		[JsonProperty("left_team_id")]
		public int LeftTeamId { get; set; }

		/// <summary>
		/// ID of the next match in the tournament for the left team. If there is no match, field value is 'null'.
		/// </summary>
		[JsonProperty("left_next_match_id")]
		public int? LeftNextMatchId { get; set; }

		/// <summary>
		/// Match results for the left team. In case of no results, field value is 'null'. If the team is disqualified, field value is '-1 '.
		/// </summary>
		[JsonProperty("left_score")]
		public int? LeftScore { get; set; }

		/// <summary>
		/// ID of the right team participating in the tournament
		/// </summary>
		[JsonProperty("right_team_id")]
		public int RightTeamId { get; set; }

		/// <summary>
		/// ID of the next match in the tournament for the right team. If there is no match, field value is 'null'.
		/// </summary>
		[JsonProperty("right_next_match_id")]
		public int? RightNextMatchId { get; set; }

		/// <summary>
		/// Match results for the right team. In case of no results, field value is 'null'. If the team is disqualified, field value is '-1 '.
		/// </summary>
		[JsonProperty("right_score")]
		public int? RightScore { get; set; }
	}
}