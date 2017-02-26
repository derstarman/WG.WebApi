using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class StrongholdPlayerStatistics
	{
		/// <summary>
		/// Player account ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Clan ID
		/// </summary>
		[JsonProperty("clan_id")]
		public int ClanId { get; set; }

		/// <summary>
		/// Total amount of Industrial Resource earned by player
		/// </summary>
		[JsonProperty("total_resources_earned")]
		public int ResourcesEarned { get; set; }

		/// <summary>
		/// Industrial Resource earned by player per week
		/// </summary>
		[JsonProperty("week_resources_earned")]
		public int ResourcesEarnedPerWeek { get; set; }

		/// <summary>
		/// Player's battle stats in the current clan's Stronghold defense.
		/// </summary>
		[JsonProperty("stronghold_defense")]
		public Statistics StrongholdDefense { get; set; } = new Statistics();

		/// <summary>
		/// Player's battle stats in the current clan's Skirmishes.
		/// </summary>
		[JsonProperty("stronghold_skirmish")]
		public Statistics StrongholdSkirmish { get; set; } = new Statistics();
	}
}