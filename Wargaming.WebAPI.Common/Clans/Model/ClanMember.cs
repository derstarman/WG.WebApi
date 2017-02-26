using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
	public class ClanMember
	{
		/// <summary>
		/// Date when player joined clan
		/// </summary>
		[JsonProperty("joined_at")]
		private double JoinedAtValue
		{
			get { return this.JoinedAt.ToDouble(); }
			set { this.JoinedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Clan creation date
		/// </summary>
		[JsonIgnore]
		public DateTime JoinedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Technical position name
		/// </summary>
		[JsonProperty("role")]
		public string ClanRole { get; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("role_i18n")]
		public string ClanRoleLocalized { get; set; }

		/// <summary>
		/// Player account ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Player name
		/// </summary>
		[JsonProperty("account_name")]
		public string AcoountName { get; set; }
	}
}