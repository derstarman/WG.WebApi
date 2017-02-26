using System.Threading.Tasks;
using Wargaming.WebAPI.Common.Requests;
using Wargaming.WebAPI.Common.Responses;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common
{
    public static partial class ContractDefinitions
    {
        public static ContractDefinition ClanListDefinition = new ContractDefinition("wgn", "clans", "list");
        public static ContractDefinition ClanInformationDefinition = new ContractDefinition("wgn", "clans", "info");
        public static ContractDefinition ClanMemberInfoDefinition = new ContractDefinition("wgn", "clans", "membersinfo");
        public static ContractDefinition ClanGlossaryDefinition = new ContractDefinition("wgn", "clans", "glossary");
        public static ContractDefinition ClanMessageBoardDefinition = new ContractDefinition("wgn", "clans", "messageboard");

        public static Task<ClanListResponse> Execute(this ClanListRequest request, Servers server)
        {
            return request.Execute<ClanListRequest, ClanListResponse>(server, ServerListDefinition);
        }

        public static Task<ClanInformationResponse> Execute(this ClanInformationRequest request, Servers server)
        {
            return request.Execute<ClanInformationRequest, ClanInformationResponse>(server, ServerListDefinition);
        }

        public static Task<ClanMemberInfoResponse> Execute(this ClanMemberInfoRequest request, Servers server)
        {
            return request.Execute<ClanMemberInfoRequest, ClanMemberInfoResponse>(server, ServerListDefinition);
        }

        public static Task<ClanGlossaryResponse> Execute(this ClanGlossaryRequest request, Servers server)
        {
            return request.Execute<ClanGlossaryRequest, ClanGlossaryResponse>(server, ServerListDefinition);
        }

        public static Task<ClanMessageBoardResponse> Execute(this ClanMessageBoardRequest request, Servers server)
        {
            return request.Execute<ClanMessageBoardRequest, ClanMessageBoardResponse>(server, ServerListDefinition);
        }        
    }
}