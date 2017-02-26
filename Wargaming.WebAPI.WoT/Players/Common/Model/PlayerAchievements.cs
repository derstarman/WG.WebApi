using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerAchievements
	{
		/// <summary>
		/// Achievements earned
		/// </summary>
		[JsonProperty("achievements")]
		public Dictionary<string, int> Achievements { get; set; }

		/// <summary>
		/// Current values of Achievement Series
		/// </summary>
		[JsonProperty("series")]
		public Dictionary<string, int> Series { get; set; }

		/// <summary>
		/// Maximum values of achievement series
		/// </summary>
		[JsonProperty("max_series")]
		public Dictionary<string, int> MaxSeries { get; set; }
	}
}
