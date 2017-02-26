using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Wargaming.WebAPI.Common.Model
{
	public class ClanInformation : Clan
	{
		/// <summary>
		/// Time when clan details were updated
		/// </summary>
		[JsonProperty("updated_at")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Time when clan details were updated
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();
				
		/// <summary>
		/// Time (UTC) when clan name was changed
		/// </summary>
		[JsonProperty("renamed_at")]
		private double RenamedAtValue
		{
			get { return this.RenamedAt.ToDouble(); }
			set { this.RenamedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Time (UTC) when clan name was changed
		/// </summary>
		[JsonIgnore]
		public DateTime RenamedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Commander's name
		/// </summary>
		[JsonProperty("leader_name")]
		public string ClanLeaderAccountName { get; set; }

		/// <summary>
		/// Clan Commander ID
		/// </summary>
		[JsonProperty("leader_id")]
		public int ClanLeaderAccountId { get; set; }

		/// <summary>
		/// Old clan tag
		/// </summary>
		[JsonProperty("old_tag")]
		public string ClanOldTag { get; set; }

		/// <summary>
		/// Old clan name
		/// </summary>
		[JsonProperty("old_name")]
		public string ClanOldName { get; set; }

		/// <summary>
		/// Clan can invite players
		/// </summary>
		[JsonProperty("accepts_join_requests")]
		public bool ClanAcceptsJoinRequests { get; set; }

		/// <summary>
		/// Clan has been deleted. The deleted clan data contains valid values for the following
		/// fields only: clan_id, is_clan_disbanded, updated_at.
		/// </summary>
		[JsonProperty("is_clan_disbanded")]
		public bool IsClanDisbanded { get; set; }

		/// <summary>
		/// Clan motto
		/// </summary>
		[JsonProperty("motto")]
		public string ClanMotto { get; set; }

		/// <summary>
		/// Clan description
		/// </summary>
		[JsonProperty("description")]
		public string ClanDescription { get; set; }

		/// <summary>
		/// Clan description in HTML
		/// </summary>
		[JsonProperty("description_html")]
		public string ClanDescriptionHtml { get; set; }

		/// <summary>
		/// Clan creator's name
		/// </summary>
		[JsonProperty("creator_name")]
		public string ClanCreatorAccountName { get; set; }

		/// <summary>
		/// Clan creator ID
		/// </summary>
		[JsonProperty("creator_id")]
		public int ClanCreatorAccountId { get; set; }

		/// <summary>
		/// Information on clan members. Field format depends on members_key input parameter.
		/// </summary>
		[JsonProperty("members")]
		public List<ClanMember> ClanMembers { get; set; }

		/// <summary>
		/// Restricted clan information
		/// </summary>
		[JsonProperty("private")]
		public ClanPrivateInformation PrivateData { get; set; }
	}
}