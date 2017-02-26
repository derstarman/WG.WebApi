using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class GroupedContacts
	{
		/// <summary>
		/// Blocked
		/// </summary>
		[JsonProperty("blocked")]
		public List<int> Blocked { get; set; }

		/// <summary>
		/// Ignored
		/// </summary>
		[JsonProperty("ignored")]
		public List<int> Ignored { get; set; }

		/// <summary>
		/// Muted
		/// </summary>
		[JsonProperty("muted")]
		public List<int> Muted { get; set; }

		/// <summary>
		/// Not grouped
		/// </summary>
		[JsonProperty("ungrouped")]
		public List<int> Ungrouped { get; set; }

		/// <summary>
		/// Groups
		/// </summary>
		[JsonProperty("groups")]
		public Dictionary<string, List<int>> Groups { get; set; }
	}
}