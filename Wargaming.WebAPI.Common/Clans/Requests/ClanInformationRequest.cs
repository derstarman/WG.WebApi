using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Common.Requests
{
	public static class ClanInformation_ExtraFields
	{
		public const string PRIVATE_ONLINE_MEMBERS = "private.online_members";
	}

	public class ClanInformationRequest : RequestBase
	{
		/// <summary>
		/// Clan ID's
		/// </summary>
		[JsonProperty("clan_id")]
		private string RequestedClanIdsValue
		{
			get { return string.Join(",", this.RequestedClanIds); }
			set { this.RequestedClanIds = value.Split(',').Select(x => int.Parse(x)).ToList(); }
		}

		/// <summary>
		/// Clan ID's
		/// </summary>
		[JsonIgnore]
		public List<int> RequestedClanIds { get; set; } = new List<int>();


		/// <summary>
		/// Extra fields to be included into the response. Valid values:
		///
		/// - private.online_members
		///
		/// </summary>
		[JsonProperty("extra")]
		private string ExtraFieldsValue
		{
			get { return string.Join(",", this.ExtraFields); }
			set { this.ExtraFields = value.Split(',').ToList(); }
		}

		/// <summary>
		/// Extra fields to be included into the response. Valid values:
		///
		/// - private.online_members
		/// 
		/// </summary>
		[JsonIgnore]
		public List<string> ExtraFields { get; set; } = new List<string>();
	}
}