using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition StrongholdClanInformationDefinition = new ContractDefinition("wot", "stronghold", "info");
		internal static ContractDefinition StrongholdBuildingsDefinition = new ContractDefinition("wot", "stronghold", "buildings");
		internal static ContractDefinition StrongholdPlayerStatisticsDefinition = new ContractDefinition("wot", "stronghold", "accountstats");
		internal static ContractDefinition StrongholdBattlesDefinition = new ContractDefinition("wot", "stronghold", "plannedbattles");

		public static Task<StrongholdClanInformationResponse> Execute(this StrongholdClanInformationRequest request, Servers server)
		{
			return request.Execute<StrongholdClanInformationRequest, StrongholdClanInformationResponse>(server, StrongholdClanInformationDefinition);
		}

		public static Task<StrongholdBuildingsResponse> Execute(this StrongholdBuildingsRequest request, Servers server)
		{
			return request.Execute<StrongholdBuildingsRequest, StrongholdBuildingsResponse>(server, StrongholdBuildingsDefinition);
		}

		public static Task<StrongholdPlayerStatisticsResponse> Execute(this StrongholdPlayerStatisticsRequest request, Servers server)
		{
			return request.Execute<StrongholdPlayerStatisticsRequest, StrongholdPlayerStatisticsResponse>(server, StrongholdPlayerStatisticsDefinition);
		}

		public static Task<StrongholdBattlesResponse> Execute(this StrongholdBattlesRequest request, Servers server)
		{
			return request.Execute<StrongholdBattlesRequest, StrongholdBattlesResponse>(server, StrongholdBattlesDefinition);
		}
	}
}