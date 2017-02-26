using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common.Model
{
	public class Account
	{
		/// <summary>
		/// List of games player has played
		/// </summary>
		[JsonProperty("games")]
		private string[] GameValues
		{
			get { return this.Games.Select(x => x.ReplaceEnvironments()).ToArray(); }
			set { this.Games = value.Select(x => x.ReplaceEnvironments()).ToList(); }
		}

		/// <summary>
		/// List of games player has played
		/// </summary>
		[JsonIgnore]
		public List<Environments> Games { get; set; }

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
		/// Player name
		/// </summary>
		[JsonProperty("nickname")]
		public string AcoountName { get; set; }

		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }
	}
}