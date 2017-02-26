using Newtonsoft.Json;
using System.Collections.Generic;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerVehicleStatistics
	{
		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Tank ID
		/// </summary>
		[JsonProperty("tank_id")]
		public int TankId { get; set; }

		/// <summary>
		/// Availability of vehicle in the Garage. This data requires a valid access_token for the specified account.
		/// </summary>
		[JsonProperty("in_garage")]
		public bool InGarage { get; set; }		

		/// <summary>
		/// Details on vehicles destroyed. This data requires a valid access_token for the specified account.
		/// </summary>
		[JsonProperty("frags")]
		public Dictionary<string, int> Frags { get; set; }

		/// <summary>
		/// Maximum experience per battle
		/// </summary>
		[JsonProperty("max_xp")]
		public int MaximunExperience { get; set; }

		/// <summary>
		/// Maximum destroyed in battle
		/// </summary>
		[JsonProperty("max_frags")]
		public int MaximumFrags { get; set; }

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
		/// Overall Statistics
		/// </summary>
		[JsonProperty("all")]
		public Statistics All { get; set; } = new Statistics();

		/// <summary>
		/// Clan battles statistics
		/// </summary>
		[JsonProperty("clan")]
		public Statistics Clan { get; set; } = new Statistics();

		/// <summary>
		/// Tank Company battles statistics
		/// </summary>
		[JsonProperty("company")]
		public Statistics Company { get; set; } = new Statistics();

		/// <summary>
		/// Fallout statistics. [Extra field.]
		/// </summary>
		[JsonProperty("fallout")]
		public Statistics Fallout { get; set; } = new Statistics();

		/// <summary>
		/// Random battles statistics. [Extra field.]
		/// </summary>
		[JsonProperty("random")]
		public Statistics Random { get; set; } = new Statistics();

		/// <summary>
		/// All battle statistics on the Global Map
		/// </summary>
		[JsonProperty("globalmap")]
		public Statistics GlobalMap { get; set; } = new Statistics();

		/// <summary>
		/// Team battles statistics
		/// </summary>
		[JsonProperty("team")]
		public Statistics Team { get; set; } = new Statistics();

		/// <summary>
		/// Battle statistics of permanent teams
		/// </summary>
		[JsonProperty("regular_team")]
		public Statistics RegularTeam { get; set; } = new Statistics();

		/// <summary>
		/// General stats for player's battles in Stronghold defense
		/// </summary>
		[JsonProperty("stronghold_defense")]
		public Statistics StrongholdDefense { get; set; } = new Statistics();

		/// <summary>
		/// General stats for player's battles in Skirmishes
		/// </summary>
		[JsonProperty("stronghold_skirmish")]
		public Statistics StrongholdSkirmish { get; set; } = new Statistics();
	}
}