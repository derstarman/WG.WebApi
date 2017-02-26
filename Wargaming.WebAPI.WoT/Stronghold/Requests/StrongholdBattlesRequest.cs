using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class StrongholdBattlesRequest : RequestBase
	{
		[JsonRequired]
		[JsonProperty("clan_id")]
		private string RequestedClanIdsValue
		{
			get { return string.Join(",", this.RequestedClanIds); }
			set { this.RequestedClanIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		[JsonIgnore]
		public List<int> RequestedClanIds { get; set; } = new List<int>();
	}
}