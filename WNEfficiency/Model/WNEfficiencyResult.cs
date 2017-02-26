using Newtonsoft.Json;
using System.Collections.Generic;

namespace WNEfficiency
{
	public class WNEfficiencyResult
	{
		[JsonProperty("header")]
		public WNEfficiencyResultHeader Header { get; set; }

		[JsonProperty("data")]
		public List<ExpectedTankValue> ExpectedValues { get; set; }
	}
}
