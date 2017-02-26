using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class PlayerVehicleAchievementsRequest : RequestBase
	{
		[JsonProperty("tank_id")]
		private string RequestedTankIdsValue
		{
			get { return string.Join(",", this.RequestedTankIds); }
			set { this.RequestedTankIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		[JsonIgnore]
		public List<int> RequestedTankIds { get; set; } = new List<int>();

		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		[JsonIgnore]
		public bool InGarage
		{
			get { return this.InGarageValue == 1; }
			set { this.InGarageValue = value ? 1 : 0; }
		}

		[JsonProperty("in_garage")]
		public int InGarageValue { get; set; }
	}
}