using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class StrongholdInformationPrivate
	{
		/// <summary>
		/// Total amount of Industrial Resource in the Stronghold
		/// </summary>
		[JsonProperty("total_resource_amount")]
		public int ResourcesAmount { get; set; }

		/// <summary>
		/// Restricted information on structures by unique type keys
		/// </summary>
		[JsonProperty("buildings")]
		public Dictionary<string, PrivateBuildingInformation> Buildings { get; set; }

		/// <summary>
		/// Restricted information on Skirmishes
		/// </summary>
		[JsonProperty("skirmish")]
		public PrivateSkirmishInformation Skirmish { get; set; }
	}
}