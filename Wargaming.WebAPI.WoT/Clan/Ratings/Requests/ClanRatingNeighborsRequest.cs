using Newtonsoft.Json;
using System;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class ClanRatingNeighborsRequest : ListRequestBase
	{
		[JsonProperty("date")]
		private long? DateValue
		{
			get { return (long?)this.Date.ToDouble(); }
			set { this.Date = ((double?)value).ToDateTime(); }
		}

		[JsonIgnore]
		public DateTime? Date { get; set; }

		[JsonRequired]
		[JsonProperty("clan_id")]
		public int ClanId { get; set; }

		[JsonRequired]
		[JsonProperty("rank_field")]
		public string RankField { get; set; }
	}
}