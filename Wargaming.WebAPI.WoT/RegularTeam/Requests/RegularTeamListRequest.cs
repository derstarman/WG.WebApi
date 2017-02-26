using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Requests;
using Wargaming.WebAPI.WoT.Enums;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class RegularTeamListRequest : SearchRequestBase
	{
		/// <summary>
		/// Allows to sort teams by a specified parameter.
		/// </summary>
		[JsonProperty("order_by")]
		public string SortingsValue
		{
			get { return string.Join(",", this.Sortings.Select(x => x.ReplaceRegularTeamOrderType())); }
			set { this.Sortings = value.Split(',').Select(x => x.ReplaceRegularTeamOrderType()).ToList(); }
		}

		/// <summary>
		/// Allows to sort teams by a specified parameter.
		/// </summary>
		[JsonIgnore]
		public List<RegularTeamOrderType> Sortings { get; set; } = new List<RegularTeamOrderType>();
	}
}