using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class PlayerRatingsRequest : RequestBase
	{
		[JsonProperty("battle_type")]
		public string BattleType { get; set; } = PlayerRatingBattleTypes.DEFAULT;

		[JsonRequired]
		[JsonProperty("type")]
		public string RatingType { get; set; } = "all";

		[JsonRequired]
		[JsonProperty("account_id")]
		private string RequestedAccountIdsValue
		{
			get { return string.Join(",", this.RequestedAccountIds); }
			set { this.RequestedAccountIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		[JsonIgnore]
		public List<int> RequestedAccountIds { get; set; } = new List<int>();

		[JsonProperty("date")]
		private long? DateValue
		{
			get { return (long?)this.Date.ToDouble(); }
			set { this.Date = ((double?)value).ToDateTime(); }
		}

		[JsonIgnore]
		public DateTime? Date { get; set; }
	}
}