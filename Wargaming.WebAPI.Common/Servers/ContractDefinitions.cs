using System.Threading.Tasks;
using Wargaming.WebAPI.Common.Requests;
using Wargaming.WebAPI.Common.Responses;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common
{
    public static partial class ContractDefinitions
    {
        internal static ContractDefinition ServerListDefinition = new ContractDefinition("wgn", "servers", "info");

        public static Task<ServerListResponse> Execute(this ServerListRequest request, Servers server)
        {
            return request.Execute<ServerListRequest, ServerListResponse>(server, ServerListDefinition);
        }
    }   
}