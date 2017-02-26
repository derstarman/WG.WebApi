using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
	public class StrongholdBattle
	{
		/// <summary>
		/// Battle creation date
		/// </summary>
		[JsonProperty("battle_creation_date")]
		private double BattleCreatedAtValue
		{
			get { return this.BattleCreatedAt.ToDouble(); }
			set { this.BattleCreatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Battle creation date
		/// </summary>
		[JsonIgnore]
		public DateTime BattleCreatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Battle planned date
		/// </summary>
		[JsonProperty("battle_planned_date")]
		private double BattlePlannedAtValue
		{
			get { return this.BattlePlannedAt.ToDouble(); }
			set { this.BattlePlannedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Battle planned date
		/// </summary>
		[JsonIgnore]
		public DateTime BattlePlannedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Attack direction
		/// </summary>
		[JsonProperty("attack_direction")]
		public string AttackDirection { get; set; }

		/// <summary>
		/// Attacking clan name
		/// </summary>
		[JsonProperty("attacker_clan_name")]
		public string AttackerClanName { get; set; }

		/// <summary>
		/// Attacking clan tag
		/// </summary>
		[JsonProperty("attacker_clan_tag")]
		public string AttackerClanTag { get; set; }

		/// <summary>
		/// Attacking clan ID
		/// </summary>
		[JsonProperty("attacker_clan_id")]
		public int AttackerClanId { get; set; }

		/// <summary>
		/// Defense direction
		/// </summary>
		[JsonProperty("defense_direction")]
		public string DefenseDirection { get; set; }

		/// <summary>
		/// Defending clan name
		/// </summary>
		[JsonProperty("defender_clan_name")]
		public string DefenderClanName { get; set; }

		/// <summary>
		/// Defending clan tag
		/// </summary>
		[JsonProperty("defender_clan_tag")]
		public string DefenderClanTag { get; set; }

		/// <summary>
		/// Defending clan ID
		/// </summary>
		[JsonProperty("defender_clan_id")]
		public int DefenderClanId { get; set; }
	}
}