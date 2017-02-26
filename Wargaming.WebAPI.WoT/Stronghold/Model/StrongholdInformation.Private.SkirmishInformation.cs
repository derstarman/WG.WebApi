using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PrivateSkirmishInformation
	{
		/// <summary>
		/// Number of Skirmishes in Absolute division
		/// </summary>
		[JsonProperty("absolute_battles_count")]
		public int BattlesCountAbsolute { get; set; }

		/// <summary>
		/// Number of Skirmishes in Champion division
		/// </summary>
		[JsonProperty("champion_battles_count")]
		public int BattlesCountChampion { get; set; }

		/// <summary>
		/// Number of Skirmishes in Medium division
		/// </summary>
		[JsonProperty("middle_battles_count")]
		public int BattlesCountMiddle { get; set; }

		/// <summary>
		/// Industrial Resource earned in Skirmishes of Absolute division
		/// </summary>
		[JsonProperty("absolute_resource_capture")]
		public int ResourcesEarnedAbsolute { get; set; }

		/// <summary>
		/// Industrial Resource earned in Skirmishes of Champion division
		/// </summary>
		[JsonProperty("champion_resource_capture")]
		public int ResourcesEarnedChampion { get; set; }

		/// <summary>
		/// Industrial Resource earned in Skirmishes of Medium division
		/// </summary>
		[JsonProperty("middle_resource_capture")]
		public int ResourcesEarnedMiddle { get; set; }
	}
}