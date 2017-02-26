using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.WoT.Model.Enums;

namespace Wargaming.WebAPI.WoT.Model
{
	public class ClanRating
	{
		/// <summary>
		/// Clan ID
		/// </summary>
		[JsonProperty("clan_id")]
		public int ClanId { get; set; }

		/// <summary>
		/// Clan name
		/// </summary>
		[JsonProperty("clan_name")]
		public int ClanName { get; set; }

		/// <summary>
		/// Clan tag
		/// </summary>
		[JsonProperty("clan_tag")]
		public int ClanTag { get; set; }

		/// <summary>
		/// Reasons why specified rating categories were not calculated. Contains data in "key-value" format, where the key is category name and the value is reason.
		/// </summary>
		[JsonProperty("exclude_reasons")]
		private Dictionary<string, string> ExcludeReasonsValues
		{
			get { return this.ExcludeReasons.ToDictionary(x => x.Key, x => x.Value.ReplaceExcludeReason()); }
			set { this.ExcludeReasons = value.ToDictionary(x => x.Key, x => x.Value.ReplaceExcludeReason()); }
		}

		/// <summary>
		/// Reasons why specified rating categories were not calculated. Contains data in "key-value" format, where the key is category name and the value is reason.
		/// </summary>
		[JsonIgnore]
		public Dictionary<string, ExcludeReason> ExcludeReasons { get; set; }

		/// <summary>
		/// Average number of battles
		/// </summary>
		[JsonProperty("battles_count_avg")]
		public RatingEntry AverageBattlesCount { get; set; }

		/// <summary>
		/// Average number of battles per day
		/// </summary>
		[JsonProperty("battles_count_avg_daily")]
		public RatingEntry DailyAverageBattlesCount { get; set; }

		/// <summary>
		/// Indicator of clan's performance.
		/// </summary>
		[JsonProperty("efficiency")]
		public RatingEntry Efficiency { get; set; }

		/// <summary>
		/// Elo rating in Battles for Stronghold in Absolute division
		/// </summary>
		[JsonProperty("fb_elo_rating_10")]
		public RatingEntry StrongholdEloRatingAbsolute { get; set; }

		/// <summary>
		/// Elo rating in Battles for Stronghold in Champion division
		/// </summary>
		[JsonProperty("fb_elo_rating_8")]
		public RatingEntry StrongholdEloRatingChampion { get; set; }

		/// <summary>
		/// Clan Elo rating in Battles for Stronghold
		/// </summary>
		[JsonProperty("fb_elo_rating")]
		public RatingEntry StrongholdEloRating { get; set; }

		/// <summary>
		/// Elo rating on the Global Map in Absolute division
		/// </summary>
		[JsonProperty("gm_elo_rating_10")]
		public RatingEntry GlobalMapEloRatingAbsolute { get; set; }

		/// <summary>
		/// Elo rating on the Global Map in Champion division
		/// </summary>
		[JsonProperty("gm_elo_rating_8")]
		public RatingEntry GlobalMapEloRatingChampion { get; set; }

		/// <summary>
		/// Elo rating on the Global Map in Medium division
		/// </summary>
		[JsonProperty("gm_elo_rating_6")]
		public RatingEntry GlobalMapEloRatingMedium { get; set; }

		/// <summary>
		/// Elo rating on the Global Map
		/// </summary>
		[JsonProperty("gm_elo_rating")]
		public RatingEntry GlobalMapEloRating { get; set; }

		/// <summary>
		/// Average global rating value
		/// </summary>
		[JsonProperty("global_rating_avg")]
		public RatingEntry AverageGlobalRating { get; set; }

		/// <summary>
		/// Weighted average of global rating value
		/// </summary>
		[JsonProperty("global_rating_weighted_avg")]
		public RatingEntry WeightedAverageGlobalRating { get; set; }

		/// <summary>
		/// Rating in Battles for Stronghold
		/// </summary>
		[JsonProperty("rating_fort")]
		public RatingEntry StrongholdRating { get; set; }

		/// <summary>
		/// Average number of vehicles of Tier 10 per clan member
		/// </summary>
		[JsonProperty("v10l_avg")]
		public RatingEntry AverageTier10TankCount { get; set; }

		/// <summary>
		/// Average victory rate
		/// </summary>
		[JsonProperty("wins_ratio_avg")]
		public RatingEntry AverageWinRatio { get; set; }
	}
}