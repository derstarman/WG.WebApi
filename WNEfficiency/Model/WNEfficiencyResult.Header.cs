using Newtonsoft.Json;

namespace WNEfficiency
{
	public class WNEfficiencyResultHeader
	{
		[JsonProperty("version")]
		public int Version { get; set; }
	}
}