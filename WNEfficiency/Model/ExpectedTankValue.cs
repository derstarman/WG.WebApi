using Newtonsoft.Json;

namespace WNEfficiency
{
	public class ExpectedTankValue
	{
		[JsonProperty("IDNum")]
		public int TankId { get; set; }

		[JsonProperty("expFrag")]
		public decimal ExpectedFrags { get; set; }

		[JsonProperty("expDamage")]
		public decimal ExpectedDamage { get; set; }

		[JsonProperty("expSpot")]
		public decimal ExpectedSpotted { get; set; }

		[JsonProperty("expDef")]
		public decimal ExpectedDefended { get; set; }

		[JsonProperty("expWinRate")]
		public decimal ExpectedWinRate { get; set; }
	}
}