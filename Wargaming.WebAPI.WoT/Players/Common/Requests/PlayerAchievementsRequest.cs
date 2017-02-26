using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class PlayerAchievementsRequest : RequestBase
	{
		[JsonRequired]
		[JsonProperty("account_id")]
		private string RequestedAccountIdsValue
		{
			get { return string.Join(",", this.RequestedAccountIds); }
			set { this.RequestedAccountIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		[JsonIgnore]
		public List<int> RequestedAccountIds { get; set; } = new List<int>();
	}
}