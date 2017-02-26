using System.Threading.Tasks;
using Wargaming.WebAPI.Common.Requests;
using Wargaming.WebAPI.Common.Responses;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common
{
    public static partial class ContractDefinitions
    {
        public static ContractDefinition LeagueListDefinition = new ContractDefinition("wgn", "league", "leagues");
        public static ContractDefinition TournamentListDefinition = new ContractDefinition("wgn", "league", "tournaments");
        public static ContractDefinition TournamentBracketDefinition = new ContractDefinition("wgn", "league", "grid");
        public static ContractDefinition TournamentMatchListDefinition = new ContractDefinition("wgn", "league", "matches");
        public static ContractDefinition TeamListDefinition = new ContractDefinition("wgn", "league", "teams");
        public static ContractDefinition TeamInformationDefinition = new ContractDefinition("wgn", "league", "teaminfo");
        public static ContractDefinition HallOfFameListDefinition = new ContractDefinition("wgn", "league", "halloffame");
        public static ContractDefinition LeaguePlayerListDefinition = new ContractDefinition("wgn", "league", "players");
        public static ContractDefinition LeaguePlayerInformationDefinition = new ContractDefinition("wgn", "league", "playerinfo");

        public static Task<LeagueListResponse> Execute(this LeagueListRequest request, Servers server)
        {
            return request.Execute<LeagueListRequest, LeagueListResponse>(server, ServerListDefinition);
        }

        public static Task<TournamentListResponse> Execute(this TournamentListRequest request, Servers server)
        {
            return request.Execute<TournamentListRequest, TournamentListResponse>(server, ServerListDefinition);
        }

        public static Task<TournamentBracketListResponse> Execute(this TournamentBracketListRequest request, Servers server)
        {
            return request.Execute<TournamentBracketListRequest, TournamentBracketListResponse>(server, ServerListDefinition);
        }

        public static Task<TournamentMatchListResponse> Execute(this TournamentMatchListRequest request, Servers server)
        {
            return request.Execute<TournamentMatchListRequest, TournamentMatchListResponse>(server, ServerListDefinition);
        }

        public static Task<TeamListResponse> Execute(this TeamListRequest request, Servers server)
        {
            return request.Execute<TeamListRequest, TeamListResponse>(server, ServerListDefinition);
        }

        public static Task<TeamInformationResponse> Execute(this TeamInformationRequest request, Servers server)
        {
            return request.Execute<TeamInformationRequest, TeamInformationResponse>(server, ServerListDefinition);
        }

        public static Task<HallOfFameListResponse> Execute(this HallOfFameListRequest request, Servers server)
        {
            return request.Execute<HallOfFameListRequest, HallOfFameListResponse>(server, ServerListDefinition);
        }

        public static Task<LeaguePlayerListResponse> Execute(this LeaguePlayerListRequest request, Servers server)
        {
            return request.Execute<LeaguePlayerListRequest, LeaguePlayerListResponse>(server, ServerListDefinition);
        }

        public static Task<LeaguePlayerInformationResponse> Execute(this LeaguePlayerInformationRequest request, Servers server)
        {
            return request.Execute<LeaguePlayerInformationRequest, LeaguePlayerInformationResponse>(server, ServerListDefinition);
        }
    }
}