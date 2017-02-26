using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public static class PlayerInformation_ExtraFields
	{
		public const string PRIVATE_BOOSTERS = "private.boosters";
		public const string PRIVATE_GARAGE = "private.garage";
		public const string PRIVATE_GROUPED_CONTACTS = "private.grouped_contacts";
		public const string PRIVATE_PERSONAL_MISSIONS = "private.personal_missions";
		public const string PRIVATE_RENTED = "private.rented";
		public const string STATISTICS_FALLOUT = "statistics.fallout";
		public const string STATISTICS_GLOBALMAP_ABSOLUTE = "statistics.globalmap_absolute";
		public const string STATISTICS_GLOBALMAP_CHAMPION = "statistics.globalmap_champion";
		public const string STATISTICS_GLOBALMAP_MIDDLE = "statistics.globalmap_middle";
		public const string STATISTICS_RANDOM = "statistics.random";
	}

	public class PlayerInformationRequest : RequestBase
	{
		[JsonRequired]
		[JsonProperty("account_id")]
		private string RequestedAccountIdsValue
		{
			get { return string.Join(",", this.RequestedAccountIds); }
			set { this.RequestedAccountIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		[JsonIgnore]
		public List<int> RequestedAccountIds { get; set; } = new List<int>();

		[JsonProperty("extra")]
		private string RequestedExtraFieldsValue
		{
			get { return string.Join(",", this.RequestedExtraFields); }
			set { this.RequestedExtraFields = value.Split(',').Select(x => x.ToString()).ToList(); }
		}

		[JsonIgnore]
		public List<string> RequestedExtraFields { get; set; } = new List<string>();
	}
}