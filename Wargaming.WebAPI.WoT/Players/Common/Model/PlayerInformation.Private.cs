using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.WoT.Enums;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerInformationPrivate
	{
		/// <summary>
		/// Premium Account expiration time
		/// </summary>
		[JsonProperty("premium_expires_at")]
		private double PremiumExpiresAtValue
		{
			get { return this.PremiumExpiresAt.ToDouble(); }
			set { this.PremiumExpiresAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Premium Account expiration time
		/// </summary>
		[JsonIgnore]
		public DateTime PremiumExpiresAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Overall battle life time in seconds
		/// </summary>
		[JsonProperty("battle_life_time")]
		public double BattleLifeTimeValue
		{
			get { return this.BattleLifeTime.TotalSeconds; }
			set { this.BattleLifeTime = TimeSpan.FromSeconds(value); }
		}

		/// <summary>
		/// Overall battle life time in seconds
		/// </summary>
		[JsonIgnore]
		public TimeSpan BattleLifeTime { get; set; }

		/// <summary>
		/// Gold
		/// </summary>
		[JsonProperty("gold")]
		public int Gold { get; set; }

		/// <summary>
		/// Credits
		/// </summary>
		[JsonProperty("credits")]
		public int Credits { get; set; }

		/// <summary>
		/// Free Experience
		/// </summary>
		[JsonProperty("free_xp")]
		public int FreeExperience { get; set; }

		/// <summary>
		/// Vehicles in the Garage. [Extra Field.]
		/// </summary>
		[JsonProperty("garage")]
		public List<int> TanksInGarage { get; set; }

		/// <summary>
		/// Indicates if mobile phone number was added to the account
		/// </summary>
		[JsonProperty("is_bound_to_phone")]
		public bool IsBoundToPhone { get; set; }

		/// <summary>
		/// Indicates if the account is Premium Account
		/// </summary>
		[JsonProperty("is_premium")]
		public bool IsPremium { get; set; }

		/// <summary>
		/// Personal Missions Progress.
		/// </summary>
		[JsonProperty("personal_missions")]
		public Dictionary<string, string> PersonalMissionsValue
		{
			get { return this.PersonalMissions.ToDictionary(x => x.Key, x => x.Value.ReplacePersonalMissionProgressState()); }
			set { this.PersonalMissions = value.ToDictionary(x => x.Key, x => x.Value.ReplacePersonalMissionProgressState()); }
		}

		/// <summary>
		/// Personal Missions Progress.
		/// </summary>
		[JsonIgnore]
		public Dictionary<string, PersonalMissionProgressState> PersonalMissions { get; set; }

		/// <summary>
		/// Vehicle Rental. [Extra Field.]
		/// </summary>
		[JsonProperty("rented")]
		public Dictionary<string, RentalVehicle> RentalVehicles { get; set; }

		/// <summary>
		/// Account restrictions
		/// </summary>
		[JsonProperty("restrictions")]
		public Restrictions Restrictions { get; set; }

		/// <summary>
		/// Contact groups. [Extra Field.]
		/// </summary>
		[JsonProperty("grouped_contacts")]
		public GroupedContacts GroupedContacts { get; set; }

		/// <summary>
		/// Personal Reserves. [Extra Field.]
		/// </summary>
		[JsonProperty("boosters")]
		public Dictionary<string, PersonalReserve> PersonalReserves { get; set; }
	}
}