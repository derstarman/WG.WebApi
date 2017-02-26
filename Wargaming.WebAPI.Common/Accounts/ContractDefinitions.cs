using System.Threading.Tasks;
using Wargaming.WebAPI.Common.Requests;
using Wargaming.WebAPI.Common.Responses;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common
{
    public static partial class ContractDefinitions
    {
        internal static ContractDefinition AccountListDefinition = new ContractDefinition("wgn", "account", "list");
        internal static ContractDefinition AccountInformationDefinition = new ContractDefinition("wgn", "account", "info");

        public static Task<AccoutListResponse> Execute(this AccoutListRequest request, Servers server)
        {
            return request.Execute<AccoutListRequest, AccoutListResponse>(server, ServerListDefinition);
        }

        public static Task<AccoutInformationResponse> Execute(this AccoutInformationRequest request, Servers server)
        {
            return request.Execute<AccoutInformationRequest, AccoutInformationResponse>(server, ServerListDefinition);
        }
    }
}