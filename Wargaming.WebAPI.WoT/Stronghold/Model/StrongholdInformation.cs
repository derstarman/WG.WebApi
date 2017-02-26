using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Wargaming.WebAPI.WoT.Model
{
	public class StrongholdInformation
	{
		/// <summary>
		/// End date of Period of Neutrality
		/// </summary>
		[JsonProperty("vacation_finish")]
		private double? VacationEndValue
		{
			get { return this.VacationEnd.ToDouble(); }
			set { this.VacationEnd = value.ToDateTime(); }
		}

		/// <summary>
		/// End date of Period of Neutrality
		/// </summary>
		[JsonIgnore]
		public DateTime? VacationEnd { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Start date of Period of Neutrality 
		/// </summary>
		[JsonProperty("vacation_start")]
		private double? VacationStartValue
		{
			get { return this.VacationStart.ToDouble(); }
			set { this.VacationStart = value.ToDateTime(); }
		}

		/// <summary>
		/// Start date of Period of Neutrality 
		/// </summary>
		[JsonIgnore]
		public DateTime? VacationStart { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Total number of battles fought by clan
		/// </summary>
		[JsonProperty("battles_count_total")]
		public int BattlesCount { get; set; }

		/// <summary>
		/// Number of structures
		/// </summary>
		[JsonProperty("buildings_count")]
		public int BuildingsCount { get; set; }

		/// <summary>
		/// Ceasefire day. Indicates the index number of the weekday: 0 - Monday, ..., 6 - Sunday. If the Defense Period is not activated, value is -1.
		/// </summary>
		[JsonProperty("day_off")]
		public int CeasefireDayNo { get; set; }

		/// <summary>
		/// Indicates if the defense period is activated
		/// </summary>
		[JsonProperty("defense_mode_is_activated")]
		public bool DefenseModeActivated { get; set; }

		/// <summary>
		/// Names of Zones available in Stronghold
		/// </summary>
		[JsonProperty("directions")]
		public List<string> Directions { get; set; }
		
		/// <summary>
		/// Number of Zones
		/// </summary>
		[JsonProperty("directions_count")]
		public int DirectionsCount { get; set; }

		/// <summary>
		/// Tier
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// Server ID
		/// </summary>
		[JsonProperty("server")]
		public string Server { get; set; }

		/// <summary>
		/// Clan ID
		/// </summary>
		[JsonProperty("clan_id")]
		public int ClanId { get; set; }

		/// <summary>
		/// Clan tag
		/// </summary>
		[JsonProperty("tag")]
		public string ClanTag { get; set; }

		/// <summary>
		/// Clan name
		/// </summary>
		[JsonProperty("name")]
		public string ClanName { get; set; }

		/// <summary>
		/// Structures info by unique type IDs
		/// </summary>
		[JsonProperty("buildings")]
		public Dictionary<string, BuildingInformation> Buildings { get; set; }

		/// <summary>
		/// Information on the active Defense Period.
		/// </summary>
		[JsonProperty("defense")]
		public DefenseInformation Defense { get; set; } = new DefenseInformation();

		/// <summary>
		/// Information on Skirmishes
		/// </summary>
		[JsonProperty("skirmish")]
		public SkirmishInformation Skirmish { get; set; }

		/// <summary>
		/// Restricted Stronghold data
		/// </summary>
		[JsonProperty("private")]
		public StrongholdInformationPrivate PrivateData { get; set; }
	}
}