using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class GlobalMapFrontsRequest : ListRequestBase
	{
		/// <summary>
		/// List of Front IDs, to specify what fronts need to be returned
		/// </summary>
		[JsonProperty("front_id")]
		private string RequestedFrontIdsValue
		{
			get { return string.Join(",", this.RequestedFrontIds); }
			set { this.RequestedFrontIds = value.Split(',').ToList(); }
		}

		/// <summary>
		/// List of Front IDs, to specify what fronts need to be returned
		/// </summary>
		[JsonIgnore]
		public List<string> RequestedFrontIds { get; set; } = new List<string>();
	}
}