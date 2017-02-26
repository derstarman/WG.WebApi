using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Requests
{
	public class ProlongRequest : CommonRequestBase
	{
		[JsonRequired]
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("expires_at")]
		private double? ExpiresAtValue
		{
			get { return this.ExpiresAt.ToDouble(); }
			set { this.ExpiresAt = value.ToDateTime(); }
		}

		[JsonIgnore]
		public DateTime? ExpiresAt { get; set; }
	}
}