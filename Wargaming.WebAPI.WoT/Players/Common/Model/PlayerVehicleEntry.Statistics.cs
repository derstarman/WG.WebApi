using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerVehicleEntryStatistics
	{
		/// <summary>
		/// Battles fought
		/// </summary>
		[JsonProperty("battles")]
		public int Battles { get; set; }

		/// <summary>
		/// Victories
		/// </summary>
		[JsonProperty("wins")]
		public int Wins { get; set; }
	}
}