using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class ClanRatingsRequest : RequestBase
	{
		[JsonRequired]
		[JsonProperty("clan_id")]
		private string RequestedClanIdsValue
		{
			get { return string.Join(",", this.RequestedClanIds); }
			set { this.RequestedClanIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		[JsonIgnore]
		public List<int> RequestedClanIds { get; set; } = new List<int>();

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