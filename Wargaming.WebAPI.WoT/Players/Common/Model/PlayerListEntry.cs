using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Players.Common.Model
{
	public class PlayerListEntry
	{
		/// <summary>
		/// Player name
		/// </summary>
		[JsonProperty("nickname")]
		public string AcoountName { get; set; }

		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }
	}
}