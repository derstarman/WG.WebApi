using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WNEfficiency
{
	public static class WNEfficiencyClient
	{
		public static int CURRENT_VERSION { get; set; } = 29;

		public static async Task<WNEfficiencyResult> GetExpectedValuesAsync(int? version = null)
		{
			string result = string.Empty;
			using (var client = new HttpClient())
			{
				var uri = $"{"http"}://www.wnefficiency.net/exp/expected_tank_values_{version ?? CURRENT_VERSION}.json";
				result = await client.GetStringAsync(uri);
			}

			return JsonConvert.DeserializeObject<WNEfficiencyResult>(result);
		}
	}
}