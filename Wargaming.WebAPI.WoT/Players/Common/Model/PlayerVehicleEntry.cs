using Newtonsoft.Json;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerVehicleEntry
	{
		/// <summary>
		/// Tank ID
		/// </summary>
		[JsonProperty("tank_id")]
		public int TankId { get; set; }

		/// <summary>
		/// Mastery Badge
		/// </summary>
		[JsonProperty("mark_of_mastery")]
		public int MasteryValue
		{
			get { return (int)this.Mastery; }
			set { this.Mastery = (MasteryBadge)value; }
		}

		/// <summary>
		/// Mastery Badge
		/// </summary>
		[JsonIgnore]
		public MasteryBadge Mastery { get; set; }

		/// <summary>
		/// Vehicle statistics
		/// </summary>
		[JsonProperty("statistics")]
		public PlayerVehicleEntryStatistics Statistics { get; set; }
	}
}