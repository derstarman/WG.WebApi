using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
	public class RentalVehicle
	{
		/// <summary>
		/// Vehicle Rental expiration time
		/// </summary>
		[JsonProperty("expiration_time")]
		private double ExpirationTimeAtValue
		{
			get { return this.ExpirationTimeAt.ToDouble(); }
			set { this.ExpirationTimeAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Vehicle Rental expiration time
		/// </summary>
		[JsonIgnore]
		public DateTime ExpirationTimeAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Tank ID
		/// </summary>
		[JsonProperty("tank_id")]
		public int TankId { get; set; }

		/// <summary>
		/// Rental compensation in credits
		/// </summary>
		[JsonProperty("compensation_credits")]
		public int CompensationCredits { get; set; }

		/// <summary>
		/// Rental compensation in gold
		/// </summary>
		[JsonProperty("compensation_gold")]
		public int CompensationGold { get; set; }
	}
}