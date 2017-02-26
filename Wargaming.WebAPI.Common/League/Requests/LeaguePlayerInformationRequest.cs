using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class LeaguePlayerInformationRequest : RequestBase
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
	}
}