using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class RatingEntry
	{
		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank { get; set; }

		/// <summary>
		/// Change of position in rating
		/// </summary>
		[JsonProperty("rank_delta")]
		public int? RankDelta { get; set; }

		/// <summary>
		/// Absolute value
		/// </summary>
		[JsonProperty("value")]
		public int? Value { get; set; }
	}
}