using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class SkirmishInformation
	{
		/// <summary>
		/// Total number of Skirmishes
		/// </summary>
		[JsonProperty("battles_count")]
		public int Battles { get; set; }

		/// <summary>
		/// Number of defeats in Skirmishes
		/// </summary>
		[JsonProperty("battles_losses")]
		public int Losses { get; set; }

		/// <summary>
		/// Number of victories in Skirmishes
		/// </summary>
		[JsonProperty("battles_wins")]
		public int Wins { get; set; }

		/// <summary>
		/// Victories/Battles ratio in Skirmishes
		/// </summary>
		[JsonProperty("battles_win_percentage")]
		public double WinsRatio { get; set; }

		/// <summary>
		/// Total amount of Industrial Resource earned in Skirmishes
		/// </summary>
		[JsonProperty("total_resource_capture")]
		public int ResourcesEarned { get; set; }
	}
}