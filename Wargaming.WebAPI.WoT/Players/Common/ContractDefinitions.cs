using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition PlayerListDefinition = new ContractDefinition("wot", " account", "list");
		internal static ContractDefinition PlayerInformationDefinition = new ContractDefinition("wot", "account", "info");

		internal static ContractDefinition PlayerVehiclesDefinition = new ContractDefinition("wot", "account", "tanks");
		internal static ContractDefinition PlayerAchievementsDefinition = new ContractDefinition("wot", "account", "achievements");

		public static Task<PlayerListResponse> Execute(this PlayerListRequest request, Servers server)
		{
			return request.Execute<PlayerListRequest, PlayerListResponse>(server, PlayerListDefinition);
		}

		public static Task<PlayerAchievementsResponse> Execute(this PlayerAchievementsRequest request, Servers server)
		{
			return request.Execute<PlayerAchievementsRequest, PlayerAchievementsResponse>(server, PlayerAchievementsDefinition);
		}

		public static Task<PlayerVehiclesResponse> Execute(this PlayerVehiclesRequest request, Servers server)
		{
			return request.Execute<PlayerVehiclesRequest, PlayerVehiclesResponse>(server, PlayerVehiclesDefinition);
		}

		public static Task<PlayerInformationResponse> Execute(this PlayerInformationRequest request, Servers server)
		{
			return request.Execute<PlayerInformationRequest, PlayerInformationResponse>(server, PlayerInformationDefinition);
		}
	}
}