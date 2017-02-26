using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Wargaming.WebAPI.Common.Model
{
	public class TeamInformation : Team
	{
		/// <summary>
		/// Date when team details were updated
		/// </summary>
		[JsonProperty("updated_at")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date when team details were updated
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Team description
		/// </summary>
		[JsonProperty("description")]
		public string TeamDescription { get; set; }

		/// <summary>
		/// Team country
		/// </summary>
		[JsonProperty("country")]
		public string TeamCountry { get; set; }

		/// <summary>
		/// Team city
		/// </summary>
		[JsonProperty("city")]
		public string TeamCity { get; set; }

		/// <summary>
		/// List of team player account IDs
		/// </summary>
		[JsonProperty("player_ids")]
		public List<int> TeamMemberIds { get; set; }

		/// <summary>
		/// List of sponsors
		/// </summary>
		[JsonProperty("sponsors")]
		public List<TeamSponsor> TeamSponsors { get; set; }

		/// <summary>
		/// Links to team profiles on social networks
		/// </summary>
		[JsonProperty("socials")]
		public SocialNetworks TeamSocialNetworks { get; set; }

		/// <summary>
		/// Team statistics
		/// </summary>
		[JsonProperty("statistics")]
		public TeamStatistics TeamStatistics { get; set; }
	}
}