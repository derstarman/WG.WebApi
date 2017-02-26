using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition ClanRatingTypeDefinition = new ContractDefinition("wot", "clanratings", "types");
		internal static ContractDefinition ClanRatingDatesDefinition = new ContractDefinition("wot", "clanratings", "dates");
		internal static ContractDefinition ClanRatingsDefinition = new ContractDefinition("wot", "clanratings", "clans");
		internal static ContractDefinition ClanRatingNeighborsDefinition = new ContractDefinition("wot", "clanratings", "neighbors");
		internal static ContractDefinition ClanRatingTopDefinition = new ContractDefinition("wot", "clanratings", "top");

		public static Task<ClanRatingTypeResponse> Execute(this ClanRatingTypeRequest request, Servers server)
		{
			return request.Execute<ClanRatingTypeRequest, ClanRatingTypeResponse>(server, ClanRatingTypeDefinition);
		}

		public static Task<ClanRatingDatesResponse> Execute(this ClanRatingDatesRequest request, Servers server)
		{
			return request.Execute<ClanRatingDatesRequest, ClanRatingDatesResponse>(server, ClanRatingDatesDefinition);
		}

		public static Task<ClanRatingsResponse> Execute(this ClanRatingsRequest request, Servers server)
		{
			return request.Execute<ClanRatingsRequest, ClanRatingsResponse>(server, ClanRatingsDefinition);
		}

		public static Task<ClanRatingNeighborsResponse> Execute(this ClanRatingNeighborsRequest request, Servers server)
		{
			return request.Execute<ClanRatingNeighborsRequest, ClanRatingNeighborsResponse>(server, ClanRatingNeighborsDefinition);
		}

		public static Task<ClanRatingTopResponse> Execute(this ClanRatingTopRequest request, Servers server)
		{
			return request.Execute<ClanRatingTopRequest, ClanRatingTopResponse>(server, ClanRatingTopDefinition);
		}
	}
}