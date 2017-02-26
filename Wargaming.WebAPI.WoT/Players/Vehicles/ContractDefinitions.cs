using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition PlayerVehicleStatisticsDefinition = new ContractDefinition("wot", "tanks", "stats");
		internal static ContractDefinition PlayerVehicleAchievementsDefinition = new ContractDefinition("wot", "tanks", "achievements");

		public static Task<PlayerVehicleStatisticsResponse> Execute(this PlayerVehicleStatisticsRequest request, Servers server)
		{
			return request.Execute<PlayerVehicleStatisticsRequest, PlayerVehicleStatisticsResponse>(server, PlayerVehicleStatisticsDefinition);
		}

		public static Task<PlayerVehicleAchievementsResponse> Execute(this PlayerVehicleAchievementsRequest request, Servers server)
		{
			return request.Execute<PlayerVehicleAchievementsRequest, PlayerVehicleAchievementsResponse>(server, PlayerVehicleAchievementsDefinition);
		}
	}
}