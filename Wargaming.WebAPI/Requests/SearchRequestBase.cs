using Newtonsoft.Json;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Requests
{
	public abstract class SearchRequestBase : ListRequestBase
	{
		/// <summary>
		/// Search bar by player name. Search type and minimum string length depend on "type"
		/// parameter. If "exact" search type is used, indication of list of names, separated by
		/// commas is allowed.
		/// </summary>
		[JsonProperty("search")]
		[JsonRequired]
		public string SearchValue { get; set; }

		/// <summary>
		/// Search type. Default is startswith. Valid values:
		///
		/// "startswith" — Search by initial part of player name(case insensitive). Minimum length:
		/// 3 characters. Maximum length: 24 characters. (by default)
		///
		/// "exact" — Search by exact match of player name(case insensitive). Indication of list of
		/// names, separated by commas is allowed(up to 100 values)
		/// </summary>
		[JsonProperty("type")]
		public string SearchTypeValue
		{
			get { return this.SearchType.ReplaceSearchType(); }
			set { this.SearchType = value.ReplaceSearchType(); }
		}

		/// <summary>
		/// Search type. Default is startswith. Valid values:
		///
		/// "startswith" — Search by initial part of player name(case insensitive). Minimum length:
		/// 3 characters. Maximum length: 24 characters. (by default)
		///
		/// "exact" — Search by exact match of player name(case insensitive). Indication of list of
		/// names, separated by commas is allowed(up to 100 values)
		/// </summary>
		[JsonIgnore]
		public SearchType SearchType { get; set; }
	}
}