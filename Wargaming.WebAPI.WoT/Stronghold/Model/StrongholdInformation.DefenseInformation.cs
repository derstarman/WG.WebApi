using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class DefenseInformation
	{
		/// <summary>
		/// Total number of attacks
		/// </summary>
		[JsonProperty("attacks_count")]
		public int AttacksCount { get; set; }

		/// <summary>
		/// Number of attacks in which clan has pillaged at least one enemy structure
		/// </summary>
		[JsonProperty("attacks_wins")]
		public int AttacksWins { get; set; }

		/// <summary>
		/// Attack efficiency
		/// </summary>
		[JsonProperty("attacks_efficiency")]
		public float AttacksEfficiency { get; set; }

		/// <summary>
		/// Total number of battles
		/// </summary>
		[JsonProperty("battles_count")]
		public int BattlesCount { get; set; }

		/// <summary>
		/// Number of victories
		/// </summary>
		[JsonProperty("battles_wins")]
		public int BattlesWins { get; set; }

		/// <summary>
		/// Victories/Battles ratio
		/// </summary>
		[JsonProperty("battles_win_percentage")]
		public float BattlesEfficiency { get; set; }

		/// <summary>
		/// Total number of battles for structures
		/// </summary>
		[JsonProperty("clashes_count")]
		public int ClashesCount { get; set; }

		/// <summary>
		/// Number of attacks in which clan has pillaged at least one enemy structure
		/// </summary>
		[JsonProperty("clashes_wins")]
		public int ClashesWins { get; set; }

		/// <summary>
		/// Victories/Battles ration in battles for structures
		/// </summary>
		[JsonProperty("clashes_win_percentage")]
		public float ClashesEfficiency { get; set; }

		/// <summary>
		/// Total number of Defenses
		/// </summary>
		[JsonProperty("defenses_count")]
		public int DefensesCount { get; set; }

		/// <summary>
		/// Number of Defenses in which clan has lost no structures
		/// </summary>
		[JsonProperty("defenses_wins")]
		public int DefensesWins { get; set; }

		/// <summary>
		/// Defense efficiency
		/// </summary>
		[JsonProperty("defenses_efficiency")]
		public float DefensesEfficiency { get; set; }

		/// <summary>
		/// Command Centers captured
		/// </summary>
		[JsonProperty("capture_bases_count")]
		public int BasesCaptureCount { get; set; }

		/// <summary>
		/// Enemy structures pillaged
		/// </summary>
		[JsonProperty("capture_buildings_count")]
		public int BuildingsCaptureCount { get; set; }

		/// <summary>
		/// Industrial Resource earned
		/// </summary>
		[JsonProperty("capture_resources_count")]
		public int ResourcesCaptureCount { get; set; }

		/// <summary>
		/// Command Centers lost
		/// </summary>
		[JsonProperty("loss_bases_count")]
		public int BasesLossCount { get; set; }

		/// <summary>
		/// Clan structures pillaged
		/// </summary>
		[JsonProperty("loss_buildings_count")]
		public int BuildingsLossCount { get; set; }

		/// <summary>
		/// Industrial Resource lost
		/// </summary>
		[JsonProperty("loss_resources_count")]
		public int ResourcesLossCount { get; set; }
	}
}