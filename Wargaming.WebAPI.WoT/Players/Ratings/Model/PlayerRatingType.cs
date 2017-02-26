using Newtonsoft.Json;

namespace Wargaming.WebAPI.WoT.Model
{
	public class PlayerRatingType : RatingType
	{
		/// <summary>
		/// Rating threshold
		/// </summary>
		[JsonProperty("threshold")]
		public int Threshold { get; set; }
	}
}