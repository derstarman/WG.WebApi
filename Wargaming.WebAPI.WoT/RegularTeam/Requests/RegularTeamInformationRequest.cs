using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class RegularTeamInformationRequest : RequestBase
	{
		/// <summary>
		/// Team ID's
		/// </summary>
		[JsonProperty("team_id")]
		private string RequestedTeamIdsValue
		{
			get { return string.Join(",", this.RequestedTeamIds); }
			set { this.RequestedTeamIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Team ID's
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedTeamIds { get; set; } = new List<int>();
	}
}