using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerInformation
	{
		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Player name
		/// </summary>
		[JsonProperty("nickname")]
		public string AcoountName { get; set; }

		/// <summary>
		/// Clan ID
		/// </summary>
		[JsonProperty("clan_id")]
		public int? ClanId { get; set; }

		/// <summary>
		/// Language selected in the game client
		/// </summary>
		[JsonProperty("client_language")]
		public string ClientLanguage { get; set; }

		/// <summary>
		/// Personal rating
		/// </summary>
		[JsonProperty("global_rating")]
		public int GlobalRating { get; set; }

		/// <summary>
		///Date when player details were updated
		/// </summary>
		[JsonProperty("updated_at")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date when player details were updated
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Date when player's account was created
		/// </summary>
		[JsonProperty("created_at")]
		private double CreatedAtValue
		{
			get { return this.CreatedAt.ToDouble(); }
			set { this.CreatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date when player's account was created
		/// </summary>
		[JsonIgnore]
		public DateTime CreatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// End time of last game session
		/// </summary>
		[JsonProperty("logout_at")]
		private double LogoutAtValue
		{
			get { return this.LogoutAt.ToDouble(); }
			set { this.LogoutAt = value.ToDateTime(); }
		}

		/// <summary>
		/// End time of last game session
		/// </summary>
		[JsonIgnore]
		public DateTime LogoutAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Last battle time
		/// </summary>
		[JsonProperty("last_battle_time")]
		private double LastBattleTimeValue
		{
			get { return this.LastBattleTime.ToDouble(); }
			set { this.LastBattleTime = value.ToDateTime(); }
		}

		/// <summary>
		/// Last battle time
		/// </summary>
		[JsonIgnore]
		public DateTime LastBattleTime { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// End time of account ban
		/// </summary>
		[JsonProperty("ban_time")]
		private double? BanTimeValue
		{
			get { return this.BanTime.ToDouble(); }
			set { this.BanTime = value.ToDateTime(); }
		}

		/// <summary>
		/// End time of account ban
		/// </summary>
		[JsonIgnore]
		public DateTime? BanTime { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Account ban details
		/// </summary>
		[JsonProperty("ban_info")]
		public string BanInfo { get; set; }

		/// <summary>
		/// Player statistics
		/// </summary>
		[JsonProperty("statistics")]
		public PlayerInformationStatistics Statistics { get; set; }

		/// <summary>
		/// Player's private data
		/// </summary>
		[JsonProperty("private")]
		public PlayerInformationPrivate PrivateData { get; set; }
	}
}
