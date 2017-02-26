using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
	public class AccountPrivateInformation
	{
		/// <summary>
		/// Premium Account expiration date
		/// </summary>
		[JsonProperty("premium_expires_at")]
		private double PremiumExpiresAtValue
		{
			get { return this.PremiumExpiresAt.ToDouble(); }
			set { this.PremiumExpiresAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Premium Account expiration date
		/// </summary>
		[JsonIgnore]
		public DateTime PremiumExpiresAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Current gold balance
		/// </summary>
		[JsonProperty("gold")]
		public double Gold { get; set; }

		/// <summary>
		/// Amount of Free Experience
		/// </summary>
		[JsonProperty("free_xp")]
		public double FreeXP { get; set; }
	}
}