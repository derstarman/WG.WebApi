using Newtonsoft.Json;

namespace Wargaming.WebAPI.Model
{
	public class LoginNoFollow
	{
		/// <summary>
		/// URL where user is redirected for authentication. This URL is returned only if parameter nofollow=1 is passed in.
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }
	}
}