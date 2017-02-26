using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class Statistics
	{
		/// <summary>
		/// Damage caused by Combat Reserves [Fallout only]
		/// </summary>
		[JsonProperty("avatar_damage_dealt")]
		public int CombatReserveDamageDealt { get; set; }

		/// <summary>
		/// Destroyed by Combat Reserves [Fallout only]
		/// </summary>
		[JsonProperty("avatar_frags")]
		public int CombatReserveFrags { get; set; }

		/// <summary>
		/// Average experience per battle
		/// </summary>
		[JsonProperty("battle_avg_xp")]
		public int AverageBattleExperience { get; set; }

		/// <summary>
		/// Battles fought
		/// </summary>
		[JsonProperty("battles")]
		public int Battles { get; set; }

		/// <summary>
		/// Base capture points
		/// </summary>
		[JsonProperty("capture_points")]
		public int CapturePoints { get; set; }

		/// <summary>
		/// Damage caused
		/// </summary>
		[JsonProperty("damage_dealt")]
		public int DamageDealt { get; set; }

		/// <summary>
		/// Damage received
		/// </summary>
		[JsonProperty("damage_received")]
		public int DamageReceived { get; set; }

		/// <summary>
		/// Deaths
		/// </summary>
		[JsonProperty("death_count")]
		public int DeathCount { get; set; }

		/// <summary>
		/// Direct hits received
		/// </summary>
		[JsonProperty("direct_hits_received")]
		public int DirectHitsReceived { get; set; }

		/// <summary>
		/// Direct hits received that caused no damage
		/// </summary>
		[JsonProperty("no_damage_direct_hits_received")]
		public int DirectHitsRecievedNoDamage { get; set; }

		/// <summary>
		/// Draws
		/// </summary>
		[JsonProperty("draws")]
		public int Draws { get; set; }

		/// <summary>
		/// Base defense points
		/// </summary>
		[JsonProperty("dropped_capture_points")]
		public int DroppedCapturePoints { get; set; }

		/// <summary>
		/// Hits on enemy as a result of splash damage
		/// </summary>
		[JsonProperty("explosion_hits")]
		public int ExplosionHits { get; set; }

		/// <summary>
		/// Hits received as a result of splash damage
		/// </summary>
		[JsonProperty("explosion_hits_received")]
		public int ExplosionHitsReceived { get; set; }

		/// <summary>
		/// Flags captured in platoon [Fallout only]
		/// </summary>
		[JsonProperty("flag_capture")]
		public int FlagCapture { get; set; }

		/// <summary>
		/// Flags captured as solo player [Fallout only]
		/// </summary>
		[JsonProperty("flag_capture_solo")]
		public int FlagCaptureSolo { get; set; }

		/// <summary>
		/// Vehicles destroyed
		/// </summary>
		[JsonProperty("frags")]
		public int Frags { get; set; }

		/// <summary>
		/// Hits
		/// </summary>
		[JsonProperty("hits")]
		public int Hits { get; set; }

		/// <summary>
		/// Hit ratio
		/// </summary>
		[JsonProperty("hits_percents")]
		public int HitsPercents { get; set; }

		/// <summary>
		/// Defeats
		/// </summary>
		[JsonProperty("losses")]
		public int Losses { get; set; }

		/// <summary>
		/// Maximum Damage caused per battle
		/// </summary>
		[JsonProperty("max_damage")]
		public int MaximumDamage { get; set; }

		/// <summary>
		/// Maximum damage caused in one battle including damage from avatar [Fallout only]
		/// </summary>
		[JsonProperty("max_damage_with_avatar")]
		public int MaximumDamageWithCombatReserve { get; set; }

		/// <summary>
		/// Maximum destroyed in battle
		/// </summary>
		[JsonProperty("max_frags")]
		public int MaximumFrags { get; set; }

		/// <summary>
		/// Maximum destroyed in one battle including vehicles destroyed by avatar [Fallout only]
		/// </summary>
		[JsonProperty("max_frags_with_avatar")]
		public int MaximumFragsWithCombatReserve { get; set; }

		/// <summary>
		/// Maximum Victory points earned in Fallout [Fallout only]
		/// </summary>
		[JsonProperty("max_win_points")]
		public int MaximumWinPoints { get; set; }

		/// <summary>
		/// Maximum experience per battle
		/// </summary>
		[JsonProperty("max_xp")]
		public int MaximumExperience { get; set; }

		/// <summary>
		/// Penetrations
		/// </summary>
		[JsonProperty("piercings")]
		public int Piercings { get; set; }

		/// <summary>
		/// Penetrations received
		/// </summary>
		[JsonProperty("piercings_received")]
		public int PiercingsReceived { get; set; }

		/// <summary>
		/// Resources captured at resource points [Fallout only]
		/// </summary>
		[JsonProperty("resource_absorbed")]
		public int ResourceAbsorbed { get; set; }

		/// <summary>
		/// Shots fired
		/// </summary>
		[JsonProperty("shots")]
		public int Shots { get; set; }

		/// <summary>
		/// Enemies spotted
		/// </summary>
		[JsonProperty("spotted")]
		public int Spotted { get; set; }

		/// <summary>
		/// Battles survived
		/// </summary>
		[JsonProperty("survived_battles")]
		public int SurvivedBattles { get; set; }

		/// <summary>
		/// Victory points [Fallout only]
		/// </summary>
		[JsonProperty("win_points")]
		public int WinPoints { get; set; }

		/// <summary>
		/// Victories
		/// </summary>
		[JsonProperty("wins")]
		public int Wins { get; set; }

		/// <summary>
		/// Total experience
		/// </summary>
		[JsonProperty("xp")]
		public int TotalExperience { get; set; }

		/// <summary>
		/// Average damage caused with your assistance
		/// </summary>
		[JsonProperty("avg_damage_assisted")]
		public double AvgerageDamageAssisted { get; set; }

		/// <summary>
		/// Average damage upon your spotting
		/// </summary>
		[JsonProperty("avg_damage_assisted_radio")]
		public double AvgerageDamageAssistedSpotting { get; set; }

		/// <summary>
		/// Average damage upon your shooting the track
		/// </summary>
		[JsonProperty("avg_damage_assisted_track")]
		public double AvgerageDamageAssistedTracking { get; set; }

		/// <summary>
		/// Average damage blocked by armor per battle. Damage blocked by armor is damage received from shells (AP, HEAT and APCR) that hit a vehicle but caused no damage. Value is calculated starting from version 9.0.
		/// </summary>
		[JsonProperty("avg_damage_blocked")]
		public double AvgerageDamageBlocked { get; set; }

		/// <summary>
		/// Ratio of damage blocked by armor from AP, HEAT, and APCR shells to damage received from these types of shells. Value is calculated starting from version 9.0.
		/// </summary>
		[JsonProperty("tanking_factor")]
		public double TankingFactor { get; set; }
	}
}