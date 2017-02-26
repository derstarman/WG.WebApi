using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class TournamentMatchListRequest : RequestBase
	{
		/// <summary>
		/// Tournament ID
		/// </summary>
		[JsonProperty("tournament_id")]
		public int TournamentId { get; set; }

		/// <summary>
		/// Match ID's
		/// </summary>
		[JsonProperty("match_id")]
		private string RequestedMatchIdsValue
		{
			get { return string.Join(",", this.RequestedMatchIds); }
			set { this.RequestedMatchIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Match ID's
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedMatchIds { get; set; } = new List<int>();
	}
}