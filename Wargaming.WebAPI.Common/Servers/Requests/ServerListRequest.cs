using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public class ServerListRequest : RequestBase
	{
		[JsonProperty("game")]
		private string RequestedGamesValue
		{
			get { return string.Join(",", this.RequestedGames.Select(x => x.ReplaceEnvironments())); }
			set { this.RequestedGames = value.Split(',').Select(x => x.ReplaceEnvironments()).ToList(); }
		}

		[JsonIgnore]
		public List<Environments> RequestedGames { get; set; } = new List<Environments>();
	}
}