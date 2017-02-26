using Newtonsoft.Json;
using System;
using Wargaming.WebAPI.WoT.Enums;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PersonalReserve
	{
		/// <summary>
		/// Expiration time
		/// </summary>
		[JsonProperty("expiration_time")]
		private double ExpirationTimeValue
		{
			get { return this.ExpirationTime.ToDouble(); }
			set { this.ExpirationTime = value.ToDateTime(); }
		}

		/// <summary>
		/// Expiration time
		/// </summary>
		[JsonIgnore]
		public DateTime ExpirationTime { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Amount of Personal Reserves
		/// </summary>
		[JsonProperty("count")]
		public int Count { get; set; }

		/// <summary>
		/// Status of Personal Reserves
		/// </summary>
		[JsonProperty("state")]
		public string StateValue
		{
			get { return this.State.ReplacePersonalReserveState(); }
			set { this.State = value.ReplacePersonalReserveState(); }
		}

		/// <summary>
		/// Status of Personal Reserves.
		/// </summary>
		[JsonIgnore]
		public PersonalReserveState State { get; set; }
	}
}