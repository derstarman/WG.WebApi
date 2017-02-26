using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class GlobalMapFront
	{
		/// <summary>
		/// Front ID
		/// </summary>
		[JsonProperty("front_id")]
		public string FrontId { get; set; }

		/// <summary>
		/// Front name
		/// </summary>
		[JsonProperty("front_name")]
		public string FrontName { get; set; }

		/// <summary>
		/// Indicates presence of Fog of War
		/// </summary>
		[JsonProperty("fog_of_war")]
		public bool IsFogOfWarActive { get; set; }

		/// <summary>
		/// Indicates if a map is active
		/// </summary>
		[JsonProperty("is_active")]
		public bool IsActive { get; set; }

		/// <summary>
		/// Indicates the map type: regular map or events map
		/// </summary>
		[JsonProperty("is_event")]
		public bool IsEvent { get; set; }

		/// <summary>
		/// Indicates if vehicles blocking is active
		/// </summary>
		[JsonProperty("vehicle_freeze")]
		public bool IsVehicleBlockingActive { get; set; }

		/// <summary>
		/// Maximum battle duration in minutes
		/// </summary>
		[JsonProperty("battle_time_limit")]
		private double BattleTimeLimitValue
		{
			get { return this.BattleTimeLimit.TotalMinutes; }
			set { this.BattleTimeLimit = TimeSpan.FromMinutes(value); }
		}

		[JsonIgnore]
		public TimeSpan BattleTimeLimit { get; set; } = TimeSpan.FromMinutes(0);

		/// <summary>
		/// Average clans rating
		/// </summary>
		[JsonProperty("avg_clans_rating")]
		public int AverageClanRating { get; set; }

		/// <summary>
		/// Average minimum bid
		/// </summary>
		[JsonProperty("avg_min_bet")]
		public int AverageMinimumBid { get; set; }

		/// <summary>
		/// Average winning bid
		/// </summary>
		[JsonProperty("avg_won_bet")]
		public int AverageWinningBid { get; set; }

		/// <summary>
		/// Division cost
		/// </summary>
		[JsonProperty("division_cost")]
		public int DivisionCost { get; set; }

		/// <summary>
		/// Division daily upkeep cost
		/// </summary>
		[JsonProperty("division_wage")]
		public int DivisionWage { get; set; }

		/// <summary>
		/// Maximum number of vehicles in division
		/// </summary>
		[JsonProperty("max_tanks_per_division")]
		public int MaximumTankCountPerDivision { get; set; }

		/// <summary>
		/// Maximum vehicle Tier
		/// </summary>
		[JsonProperty("max_vehicle_level")]
		public int MaximumTankTier { get; set; }

		/// <summary>
		/// Minimum number of vehicles in division
		/// </summary>
		[JsonProperty("min_tanks_per_division")]
		public int MinimumTankCountPerDivision { get; set; }

		/// <summary>
		/// Minimum vehicle Tier
		/// </summary>
		[JsonProperty("min_vehicle_level")]
		public int MinimumTankTier { get; set; }

		/// <summary>
		/// Amount of Provinces
		/// </summary>
		[JsonProperty("provinces_count")]
		public int ProvincesCount { get; set; }

		/// <summary>
		/// Available modules
		/// </summary>
		[JsonProperty("available_extensions")]
		public List<GlobalMapFrontExtension> Extensions { get; set; }
	}
}