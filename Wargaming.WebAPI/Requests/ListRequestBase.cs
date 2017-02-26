using Newtonsoft.Json;

namespace Wargaming.WebAPI.Requests
{
	public abstract class ListRequestBase : RequestBase
	{
		/// <summary>
		/// Number of returned entries (fewer can be returned, but not more than 100). If the limit
		/// sent exceeds 100, an limit of None is applied (by default).
		/// </summary>
		[JsonProperty("limit")]
		public int Limit { get; set; } = 100;

		/// <summary>
		/// Page number
		/// </summary>
		[JsonProperty("page_no")]
		public int PageNo { get; set; } = 1;
	}
}