using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class ClanMemberInfoRequest : RequestBase
	{
		/// <summary>
		/// Account ID's
		/// </summary>
		[JsonProperty("account_id")]
		private string RequestedAccountIdsValue
		{
			get { return string.Join(",", this.RequestedAccountIds); }
			set { this.RequestedAccountIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Account ID's
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedAccountIds { get; set; } = new List<int>();
	}
}