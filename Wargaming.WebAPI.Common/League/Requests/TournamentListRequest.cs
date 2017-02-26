using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class TournamentListRequest : ListRequestBase
	{
		/// <summary>
		/// Tournament ID's
		/// </summary>
		[JsonProperty("tournament_id")]
		private string RequestedTournamentIdsValue
		{
			get { return string.Join(",", this.RequestedTournamentIds); }
			set { this.RequestedTournamentIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Tournament ID's
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedTournamentIds { get; set; } = new List<int>();

		/// <summary>
		/// Tournament status.
		/// </summary>
		[JsonProperty("status")]
		public string TournamentStatusValue
		{
			get { return this.TournamentStatus.ReplaceEventStatus(); }
			set { this.TournamentStatus = value.ReplaceEventStatus(); }
		}

		/// <summary>
		/// Tournament status.
		/// </summary>
		[JsonIgnore]
		public EventStatus TournamentStatus { get; set; }

		/// <summary>
		/// League ID
		/// </summary>
		[JsonProperty("league_id")]
		public int LeagueId { get; set; }
	}
}