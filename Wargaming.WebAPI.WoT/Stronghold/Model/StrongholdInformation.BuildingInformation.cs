using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class BuildingInformation
	{
		/// <summary>
		/// Number of players attached to the structure
		/// </summary>
		[JsonProperty("attached_account_count")]
		public int AttachedAccountCount { get; set; }

		/// <summary>
		/// List of IDs of players attached to the structure
		/// </summary>
		[JsonProperty("attached_account_ids")]
		public List<int> AttachedAccountIds { get; set; }

		/// <summary>
		/// Zone name. Value '–-' is used for Command Center only.
		/// </summary>
		[JsonProperty("direction_name")]
		public string Direction { get; set; }

		/// <summary>
		/// Structure level
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// Structure type
		/// </summary>
		[JsonProperty("type")]
		public int Type { get; set; }
	}
}