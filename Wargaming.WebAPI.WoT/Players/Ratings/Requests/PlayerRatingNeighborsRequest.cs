using Newtonsoft.Json;
using System;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class PlayerRatingNeighborsRequest : ListRequestBase
	{
		[JsonProperty("battle_type")]
		public string BattleType { get; set; } = PlayerRatingBattleTypes.DEFAULT;

		[JsonRequired]
		[JsonProperty("type")]
		public string RatingType { get; set; } = "all";

		[JsonProperty("date")]
		private long? DateValue
		{
			get { return (long?)this.Date.ToDouble(); }
			set { this.Date = ((double?)value).ToDateTime(); }
		}

		[JsonIgnore]
		public DateTime? Date { get; set; }

		[JsonRequired]
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		[JsonRequired]
		[JsonProperty("rank_field")]
		public string RankField { get; set; }
	}
}