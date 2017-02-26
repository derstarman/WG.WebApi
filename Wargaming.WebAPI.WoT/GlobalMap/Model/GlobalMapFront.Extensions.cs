using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class GlobalMapFrontExtension
	{
		/// <summary>
		/// Consumable ID
		/// </summary>
		[JsonProperty("extension_id")]
		public string ConsumableId { get; set; }

		/// <summary>
		/// Cost of modules
		/// </summary>
		[JsonProperty("cost")]
		public int Cost { get; set; }

		/// <summary>
		/// Modules upkeep cost
		/// </summary>
		[JsonProperty("wage")]
		public int Wage { get; set; }

		/// <summary>
		/// Localized consumable name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Localized description of strategic effect
		/// </summary>
		[JsonProperty("description_strategic")]
		public string StrategicDescription { get; set; }

		/// <summary>
		/// Localized description of tactical effect
		/// </summary>
		[JsonProperty("description_tactical")]
		public string TacticalDescription { get; set; }
	}
}