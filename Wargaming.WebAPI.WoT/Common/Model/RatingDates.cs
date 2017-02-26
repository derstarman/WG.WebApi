using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Model
{
	public class RatingDates
	{
		/// <summary>
		/// Dates with available ratings
		/// </summary>
		[JsonProperty("dates")]
		private List<double> DateValues
		{
			get { return this.Dates.Select(x => x.ToDouble()).ToList(); }
			set { this.Dates = value.Select(x => x.ToDateTime()).ToList(); }
		}

		/// <summary>
		/// Dates with available ratings
		/// </summary>
		[JsonIgnore]
		public List<DateTime> Dates { get; set; }
	}
}