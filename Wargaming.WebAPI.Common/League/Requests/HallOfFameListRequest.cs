using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Common.Enums;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class HallOfFameListRequest : ListRequestBase
	{
		/// <summary>
		/// Account IDs of players
		/// </summary>
		[JsonProperty("account_id")]
		private string RequestedLeaguePlayerIdsValue
		{
			get { return string.Join(",", this.RequestedLeaguePlayerIds); }
			set { this.RequestedLeaguePlayerIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Account IDs of players
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedLeaguePlayerIds { get; set; } = new List<int>();

		/// <summary>
		/// Sorting. Multiple parameters must be divided by commas.
		/// </summary>
		[JsonProperty("order_by")]
		public string SortingsValue
		{
			get { return string.Join(",", this.Sortings.Select(x => x.ReplaceTeamStatisticsOrderType())); }
			set { this.Sortings = value.Split(',').Select(x => x.ReplaceTeamStatisticsOrderType()).ToList(); }
		}

		/// <summary>
		/// Sorting.
		/// </summary>
		[JsonIgnore]
		public List<StatisticsOrderType> Sortings { get; set; } = new List<StatisticsOrderType>();
	}
}