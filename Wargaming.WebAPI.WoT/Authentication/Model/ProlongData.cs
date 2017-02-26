using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Model
{
	public class ProlongData
	{
		/// <summary>
		/// Access token is passed to all methods requiring authorization.
		/// </summary>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		/// <summary>
		/// Access_token expiration time
		/// </summary>
		[JsonProperty("expires_at")]
		private double ExpiresAtValue
		{
			get { return this.ExpiresAt.ToDouble(); }
			set { this.ExpiresAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Access_token expiration time
		/// </summary>
		[JsonIgnore]
		public DateTime ExpiresAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Player ID
		/// </summary>
		[JsonProperty("account_id")]
		public int AccountId { get; set; }
	}
}