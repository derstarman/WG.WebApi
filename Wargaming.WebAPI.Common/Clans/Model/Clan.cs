using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
	public class Clan
	{
		/// <summary>
		/// Clan creation date
		/// </summary>
		[JsonProperty("created_at")]
		private double CreatedAtValue
		{
			get { return this.CreatedAt.ToDouble(); }
			set { this.CreatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Clan creation date
		/// </summary>
		[JsonIgnore]
		public DateTime CreatedAt { get; set; } = ConverterExtensions.BaseDate();

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
		/// Number of clan members
		/// </summary>
		[JsonProperty("members_count")]
		public int ClanMembersCount { get; set; }

		/// <summary>
		/// Clan color in HEX #RRGGBB
		/// </summary>
		[JsonProperty("color")]
		public string ClanColor { get; set; }

		/// <summary>
		/// Information on clan emblems in games and on clan portal
		/// </summary>
		[JsonProperty("emblems")]
		public ClanEmblems ClanEmblems { get; set; }
	}
}
