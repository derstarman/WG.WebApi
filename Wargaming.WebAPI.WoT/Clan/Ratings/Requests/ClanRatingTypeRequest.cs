using Newtonsoft.Json;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class ClanRatingTypeRequest : CommonRequestBase
	{
		[JsonProperty("limit")]
		public int Limit { get; set; }
	}
}