using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PrivateBuildingInformation
	{
		/// <summary>
		/// Amount of Industrial Resource in the structure
		/// </summary>
		[JsonProperty("resource_amount")]
		public int ResourcesAmount { get; set; }

		/// <summary>
		/// Structure type
		/// </summary>
		[JsonProperty("type")]
		public int Type { get; set; }
	}
}