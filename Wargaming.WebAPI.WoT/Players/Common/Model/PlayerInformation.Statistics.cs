using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerInformationStatistics
	{
		/// <summary>
		/// Trees knocked down
		/// </summary>
		[JsonProperty("trees_cut")]
		public int TreesCut { get; set; }

		/// <summary>
		/// Number and models of vehicles destroyed by a player. [Private data]
		/// {TankId} -- {Frags}
		/// </summary>
		[JsonProperty("frags")]
		public Dictionary<string, int> Frags { get; set; }

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
		/// Battle statistics on the Global Map in Absolute division. [Extra field.]
		/// </summary>
		[JsonProperty("globalmap_absolute")]
		public Statistics GlobalMapAbsolute { get; set; } = new Statistics();

		/// <summary>
		/// Battle statistics on the Global Map in Champion division. [Extra field.]
		/// </summary>
		[JsonProperty("globalmap_champion")]
		public Statistics GlobalMapChampion { get; set; } = new Statistics();

		/// <summary>
		/// Battle statistics on the Global Map in Medium division. [Extra field.]
		/// </summary>
		[JsonProperty("globalmap_middle")]
		public Statistics GlobalMapMiddle { get; set; } = new Statistics();

		/// <summary>
		/// Historical battles statistics
		/// </summary>
		[JsonProperty("historical")]
		public Statistics Historical { get; set; } = new Statistics();

		/// <summary>
		/// Random battles statistics. [Extra field.]
		/// </summary>
		[JsonProperty("random")]
		public Statistics Random { get; set; } = new Statistics();

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