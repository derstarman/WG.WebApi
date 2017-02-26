using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
	public class RegularTeamPlayer
	{
		/// <summary>
		/// Date when joined the team
		/// </summary>
		[JsonProperty("joined_at")]
		private double JoinedAtValue
		{
			get { return this.JoinedAt.ToDouble(); }
			set { this.JoinedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date when joined the team
		/// </summary>
		[JsonIgnore]
		public DateTime JoinedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Technical position name in a team
		/// </summary>
		[JsonProperty("role")]
		public string TeamRole { get; set; }

		/// <summary>
		/// Player account ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }
	}
}