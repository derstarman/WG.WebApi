using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class TeamInformationRequest : RequestBase
	{
		/// <summary>
		/// Team ID
		/// </summary>
		[JsonProperty("team_id")]
		private string RequestedTeamIdsValue
		{
			get { return string.Join(",", this.RequestedTeamIds); }
			set { this.RequestedTeamIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Team ID
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedTeamIds { get; set; } = new List<int>();
	}
}