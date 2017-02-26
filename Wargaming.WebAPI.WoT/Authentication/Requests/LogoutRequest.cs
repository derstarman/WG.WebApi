using Newtonsoft.Json;

namespace Wargaming.WebAPI.Requests
{
	public class LogoutRequest : CommonRequestBase
	{
		[JsonRequired]
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }
	}
}