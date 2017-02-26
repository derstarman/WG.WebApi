using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class RegularTeamInformation : RegularTeam
	{
		/// <summary>
		/// Date when team data were updated
		/// </summary>
		[JsonProperty("updated_at")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date when team data were updated
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Team creation date
		/// </summary>
		[JsonProperty("created_at")]
		private double CreatedAtValue
		{
			get { return this.CreatedAt.ToDouble(); }
			set { this.CreatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Team creation date
		/// </summary>
		[JsonIgnore]
		public DateTime CreatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Team description
		/// </summary>
		[JsonProperty("description")]
		public string TeamDescription { get; set; }

		/// <summary>
		/// Short team description
		/// </summary>
		[JsonProperty("short_description")]
		public string TeamShortDescription { get; set; }

		/// <summary>
		/// Number of battles played by a team
		/// </summary>
		[JsonProperty("battles_count")]
		public int TeamBattles { get; set; }

		/// <summary>
		/// Number of victories of a team
		/// </summary>
		[JsonProperty("wins_count")]
		public int TeamBattlesWon { get; set; }

		/// <summary>
		/// Team can invite players
		/// </summary>
		[JsonProperty("accepts_join_requests")]
		public bool TeamCanInvitePlayers { get; set; }

		/// <summary>
		/// Team can participate in Random Battles
		/// </summary>
		[JsonProperty("allow_random_battles")]
		public bool TeamAllowsRandomBattles { get; set; }

		/// <summary>
		/// List of team members
		/// </summary>
		[JsonProperty("players")]
		public List<RegularTeamPlayer> TeamMembers { get; set; }
	}
}