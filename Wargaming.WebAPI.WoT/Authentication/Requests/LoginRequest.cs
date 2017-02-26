using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Requests
{
	public static class Login_DisplayTypes
	{
		public const string PAGE = "page";
		public const string POPUP = "popup";
	}

	public class LoginRequest : CommonRequestBase
	{
		[JsonProperty("expires_at")]
		private double? ExpiresAtValue
		{
			get { return this.ExpiresAt.ToDouble(); }
			set { this.ExpiresAt = value.ToDateTime(); }
		}

		[JsonIgnore]
		public DateTime? ExpiresAt { get; set; }

		[JsonProperty("redirect_uri")]
		public string RedirectUri { get; set; }

		[JsonProperty("display")]
		public string Display { get; set; } = Login_DisplayTypes.POPUP;

		[JsonProperty("nofollow")]
		public int NoFollow { get; set; }
	}
}