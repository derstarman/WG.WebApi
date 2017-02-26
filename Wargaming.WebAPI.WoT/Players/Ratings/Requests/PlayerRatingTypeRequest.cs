using Newtonsoft.Json;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.WoT.Requests
{
	public class PlayerRatingTypeRequest : RequestBase
	{
		[JsonProperty("battle_type")]
		public string BattleType { get; set; } = PlayerRatingBattleTypes.DEFAULT;
	}
}