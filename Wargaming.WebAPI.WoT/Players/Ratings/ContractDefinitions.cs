using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition PlayerRatingTypeDefinition = new ContractDefinition("wot", "ratings", "types");
		internal static ContractDefinition PlayerRatingDatesDefinition = new ContractDefinition("wot", "ratings", "dates");
		internal static ContractDefinition PlayerRatingsDefinition = new ContractDefinition("wot", "ratings", "accounts");
		internal static ContractDefinition PlayerRatingNeighborsDefinition = new ContractDefinition("wot", "ratings", "neighbors");
		internal static ContractDefinition PlayerRatingTopDefinition = new ContractDefinition("wot", "ratings", "top");

		public static Task<PlayerRatingTypeResponse> Execute(this PlayerRatingTypeRequest request, Servers server)
		{
			return request.Execute<PlayerRatingTypeRequest, PlayerRatingTypeResponse>(server, PlayerRatingTypeDefinition);
		}

		public static Task<PlayerRatingDatesResponse> Execute(this PlayerRatingDatesRequest request, Servers server)
		{
			return request.Execute<PlayerRatingDatesRequest, PlayerRatingDatesResponse>(server, PlayerRatingDatesDefinition);
		}

		public static Task<PlayerRatingsResponse> Execute(this PlayerRatingsRequest request, Servers server)
		{
			return request.Execute<PlayerRatingsRequest, PlayerRatingsResponse>(server, PlayerRatingsDefinition);
		}

		public static Task<PlayerRatingNeighborsResponse> Execute(this PlayerRatingNeighborsRequest request, Servers server)
		{
			return request.Execute<PlayerRatingNeighborsRequest, PlayerRatingNeighborsResponse>(server, PlayerRatingNeighborsDefinition);
		}

		public static Task<PlayerRatingTopResponse> Execute(this PlayerRatingTopRequest request, Servers server)
		{
			return request.Execute<PlayerRatingTopRequest, PlayerRatingTopResponse>(server, PlayerRatingTopDefinition);
		}
	}
}