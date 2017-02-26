using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerVehicleAchievements
	{
		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Tank ID
		/// </summary>
		[JsonProperty("tank_id")]
		public int TankId { get; set; }

		/// <summary>
		/// Achievements earned
		/// </summary>
		[JsonProperty("achievements")]
		public Dictionary<string, int> Achievements { get; set; }

		/// <summary>
		/// Current values of Achievement Series
		/// </summary>
		[JsonProperty("series")]
		public Dictionary<string, int> Series { get; set; }

		/// <summary>
		/// Maximum values of achievement series
		/// </summary>
		[JsonProperty("max_series")]
		public Dictionary<string, int> MaxSeries { get; set; }
	}
}