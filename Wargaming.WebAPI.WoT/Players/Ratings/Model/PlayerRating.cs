using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerRating
	{
		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Number of battles left to be included in ratings
		/// </summary>
		[JsonProperty("battles_to_play")]
		public int BattlesToPlay { get; set; }

		/// <summary>
		/// Survive ratio
		/// </summary>
		[JsonProperty("survived_ratio")]
		public RatingEntry SurvivedRatio { get; set; }

		/// <summary>
		/// Base capture points
		/// </summary>
		[JsonProperty("capture_points")]
		public RatingEntry CapturePoints { get; set; }

		/// <summary>
		/// Victories/Battles ratio
		/// </summary>
		[JsonProperty("wins_ratio")]
		public RatingEntry WinsRatio { get; set; }

		/// <summary>
		/// Vehicles spotted
		/// </summary>
		[JsonProperty("spotted_count")]
		public RatingEntry SpottedCount { get; set; }

		/// <summary>
		/// Average number of vehicles destroyed per battle
		/// </summary>
		[JsonProperty("frags_avg")]
		public RatingEntry AverageFrags { get; set; }

		/// <summary>
		/// Hit ratio
		/// </summary>
		[JsonProperty("hits_ratio")]
		public RatingEntry HitsRatio { get; set; }

		/// <summary>
		/// Total experience
		/// </summary>
		[JsonProperty("xp_amount")]
		public RatingEntry ExperienceAmount { get; set; }

		/// <summary>
		/// Maximum experience per battle
		/// </summary>
		[JsonProperty("xp_max")]
		public RatingEntry MaximumExperience { get; set; }

		/// <summary>
		/// Average experience per battle
		/// </summary>
		[JsonProperty("xp_avg")]
		public RatingEntry AverageExperience { get; set; }

		/// <summary>
		/// Vehicles destroyed
		/// </summary>
		[JsonProperty("frags_count")]
		public RatingEntry FragsCount { get; set; }

		/// <summary>
		/// Average number of vehicles spotted per battle
		/// </summary>
		[JsonProperty("spotted_avg")]
		public RatingEntry AverageSpotted { get; set; }

		/// <summary>
		/// Total damage caused
		/// </summary>
		[JsonProperty("damage_dealt")]
		public RatingEntry DamageDealt { get; set; }

		/// <summary>
		/// Personal rating
		/// </summary>
		[JsonProperty("global_rating")]
		public RatingEntry GlobalRating { get; set; }

		/// <summary>
		/// Average damage caused per battle
		/// </summary>
		[JsonProperty("damage_avg")]
		public RatingEntry AverageDamage { get; set; }

		/// <summary>
		/// Battles fought
		/// </summary>
		[JsonProperty("battles_count")]
		public RatingEntry BattlesCount { get; set; }
	}
}