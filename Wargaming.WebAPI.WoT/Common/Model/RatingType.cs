using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class RatingType
	{
		/// <summary>
		/// Rating period
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Rating categories
		/// </summary>
		[JsonProperty("rank_fields")]
		public List<string> RankFields { get; set; }
	}
}