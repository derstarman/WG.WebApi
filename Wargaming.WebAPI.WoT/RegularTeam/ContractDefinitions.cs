using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
    public static partial class ContractDefinitions
    {
        internal static ContractDefinition RegularTeamListDefinition = new ContractDefinition("wot", "regularteams", "list");
        internal static ContractDefinition RegularTeamInformationDefinition = new ContractDefinition("wot", "regularteams", "info");

        public static Task<RegularTeamListResponse> Execute(this RegularTeamListRequest request, Servers server)
        {
            return request.Execute<RegularTeamListRequest, RegularTeamListResponse>(server, RegularTeamListDefinition);
        }

        public static Task<RegularTeamInformationResponse> Execute(this RegularTeamInformationRequest request, Servers server)
        {
            return request.Execute<RegularTeamInformationRequest, RegularTeamInformationResponse>(server, RegularTeamInformationDefinition);
        }
    }
}