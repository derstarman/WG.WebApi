using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Wargaming.WebAPI.Common.Enums;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common.Model
{
	public class Tournament
	{
		/// <summary>
		/// Tournament ID
		/// </summary>
		[JsonProperty("tournament_id")]
		public int TournamentId { get; set; }

		/// <summary>
		/// League ID
		/// </summary>
		[JsonProperty("league_id")]
		public int LeagueId { get; set; }

		/// <summary>
		/// Season ID
		/// </summary>
		[JsonProperty("season_id")]
		public int SeasonId { get; set; }

		/// <summary>
		/// Stage ID
		/// </summary>
		[JsonProperty("stage_id")]
		public int StageId { get; set; }

		/// <summary>
		/// Season name
		/// </summary>
		[JsonProperty("name_i18n")]
		public string TournamentNameLocalized { get; set; }

		/// <summary>
		/// List of participating teams IDs
		/// </summary>
		[JsonProperty("team_ids")]
		public List<int> TeamIds { get; set; }

		/// <summary>
		/// Date of the last tournament info update
		/// </summary>
		[JsonProperty("updated_at")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date of the last tournament info update
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Date of the last tournament matches info update
		/// </summary>
		[JsonProperty("matches_updated_at")]
		private double MatchesUpdatedAtValue
		{
			get { return this.MatchesUpdatedAt.ToDouble(); }
			set { this.MatchesUpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date of the last tournament matches info update
		/// </summary>
		[JsonIgnore]
		public DateTime MatchesUpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Tournament status: 'active' or 'complete'
		/// </summary>
		[JsonProperty("status")]
		public string TournamentStatusValue
		{
			get { return this.Status.ReplaceEventStatus(); }
			set { this.Status = value.ReplaceEventStatus(); }
		}

		/// <summary>
		/// Tournament status: 'active' or 'complete'
		/// </summary>
		[JsonIgnore]
		public EventStatus Status { get; set; }

		/// <summary>
		/// Tournament type: 'RR' - round robin, 'DE' - double elimination, 'SE' - single elimination, 'SE_KR' - single elimination for Korea
		/// </summary>
		[JsonProperty("type")]
		public string TournamentTypeValue
		{
			get { return this.Type.ReplaceTournamentType(); }
			set { this.Type = value.ReplaceTournamentType(); }
		}

		/// <summary>
		/// Tournament type: 'RR' - round robin, 'DE' - double elimination, 'SE' - single elimination, 'SE_KR' - single elimination for Korea
		/// </summary>
		[JsonIgnore]
		public TournamentType Type { get; set; }
	}
}