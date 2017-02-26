using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wargaming.WebAPI.Requests;
using Wargaming.WebAPI.WoT.Enums;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class GlobalMapProvincesRequest : ListRequestBase
	{
		/// <summary>
		/// Front ID
		/// </summary>
		[JsonProperty("front_id")]
		[JsonRequired]
		public string FrontId { get; set; }

		/// <summary>
		/// Map ID
		/// </summary>
		[JsonProperty("arena_id")]
		public string ArenaId { get; set; }

		/// <summary>
		/// Filter by the list of province IDs
		/// </summary>
		[JsonProperty("province_id")]
		private string RequestedProvinceIdsValue
		{
			get { return string.Join(",", this.RequestedProvinceIds); }
			set { this.RequestedProvinceIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Filter by the list of province IDs
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedProvinceIds { get; set; } = new List<int>();

		/// <summary>
		/// Search for provinces with daily income equal to or less than the value
		/// </summary>
		[JsonProperty("daily_revenue_lte")]
		public int DailyRevenueLowerAs { get; set; }

		/// <summary>
		/// Search for provinces with daily income equal to or more than the value
		/// </summary>
		[JsonProperty("daily_revenue_gte")]
		public int DailyRevenueGreaterAs { get; set; }

		/// <summary>
		/// Search for provinces with the value of Prime Time start hour. Values available: from 0 to 23.
		/// </summary>
		[JsonProperty("prime_hour")]
		public int PrimeHour { get; set; }

		/// <summary>
		/// Sorting
		/// </summary>
		[JsonProperty("order_by")]
		private string SortingValue
		{
			get { return this.Sorting.ReplaceProvincesOrderType(); }
			set { this.Sorting = value.ReplaceProvincesOrderType(); }
		}

		/// <summary>
		/// Sorting
		/// </summary>
		[JsonIgnore]
		public ProvincesOrderType Sorting { get; set; }

		/// <summary>
		/// Search for provinces by landing type.
		/// </summary>
		[JsonProperty("landing_type")]
		private string LandingTypeValue
		{
			get { return this.LandingType.ReplaceProvincesLandingType(); }
			set { this.LandingType = value.ReplaceProvincesLandingType(); }
		}

		/// <summary>
		///Search for provinces by landing type.
		/// </summary>
		[JsonIgnore]
		public ProvincesLandingType LandingType { get; set; }
	}
}
